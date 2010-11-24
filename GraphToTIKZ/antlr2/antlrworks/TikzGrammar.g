grammar TikzGrammar;

options {
    output=AST;
    ASTLabelType=CommonTree; 
    backtrack = true;
}

t_file  :       t_main_structures* ->  ^( FILE t_main_structures* )
        ;

t_main_structures
        :       (function | square_brackets | curly_brackets | t_block | t_list | t_macro)
        ->      function* square_brackets* curly_brackets* t_block* t_list* t_macro*
        ;
        
        
t_block :       BACKSLASH BEGIN '{' block_name+=string '}' ( '{' block_name+=string '}' )? t_main_structures* BACKSLASH END '{' string '}'
        ->      ^( BLOCK ^( NAME $block_name )* t_main_structures*  )
        ;

t_macro :       BACKSLASH 
                        ( t_foreach
        ->              t_foreach
        
                        | t_node
        ->              t_node
        
                        | t_coordinate
        ->              t_coordinate
                        
                        |( macro_name=string t_macro?           
                        ( t_options | t_lineto | t_moveto | t_lineto_hv 
                        | t_lineto_vh | t_cycle | t_curve |t_rectangle | t_gird | t_parabola | t_plot | t_edge 
                        | t_to_path | t_to_path |  t_foreach | t_edge | add_blocks+=curly_brackets |add_blocks+=t_block 
                        | t_circle | t_ellipse | t_arc| str+=string | t_foreach | t_node | t_coordinate )* ) 
        ->              ^( MACRO ^( NAME $macro_name ) t_macro? t_options* t_moveto* t_lineto*  
                        t_lineto_hv* t_lineto_vh* t_cycle* t_to_path* t_foreach* t_edge* t_curve* t_rectangle*
                        t_gird* t_plot*  t_circle* t_ellipse* t_parabola* t_arc* $add_blocks* $str* 
                        t_foreach* t_node* t_coordinate* )              
                ) ';'?
        ;

curly_brackets
        :       '{' t_main_structures* '}'
        ->      ^( BLOCK t_main_structures* )
        ;
        
function
        :       FUNC? '('(function|  curly_brackets|  t_list| t_macro)* ')' 
        ->      ^( FUNCTION  ^(NAME FUNC)? function*  curly_brackets*  t_list* t_macro* )

        ;
        
square_brackets
        :       '['   
        //( function | square_brackets | curly_brackets | t_block | t_list | t_macro )* 
        ']'
        //->    ^( OPTIONS  function* square_brackets* curly_brackets* t_block* t_list* t_macro* )
        ;

t_list
        :       (  t_list_elem | ',' | ':' | AND )+
        ->      ^( LIST t_list_elem*  )
        ;

t_list_elem
        :       ( ( elem_name+=t_macro | elem_name+=string | elem_name+=function | elem_name+=curly_brackets  | elem_name+=square_brackets | elem_name+=t_lineto )?
                oper=multioperator ( elem_value+=t_macro | elem_value+=string | elem_value+=function | elem_value+=curly_brackets  | elem_value+=square_brackets | elem_name+=t_lineto ) )
        ->      ^(OPERATION $oper ^( NAME $elem_name? ) ^( VALUE $elem_value ) ) 
                | ( elem_name+=t_macro | elem_name+=string | elem_name+=function | elem_name+=curly_brackets  | elem_name+=square_brackets |  elem_name+=t_lineto ) 
                ->  ^( NAME $elem_name )
                ;
                
t_options       
        :       '[' ( t_list_elem | ',' | ':' )+ ']'
        ->      ^( OPTIONS t_list_elem* )
        ;                       


                
multioperator
        :       OPERATOR+
        ;

        
string  :       //  Ciag znakow poprzedzony operatorami albo same operatory, np.: <=>
                (OPERATOR* STRING+)
                | OPERATOR+
                // Slowa kluczowe bez OPERATOR ORAZ BACKSLASH
                |BEGIN|END|HVLINE|VHLINE|TO|IN|CYCLE|FOREACH|CS|NODE
                |AT|FUNC|FUNCTION|FILE|COORDINATES|COORDINATE|EDGE|AND|CONTROLS|FROM|PARENT
                |DOTS|RECTANGLE|GRID|PLOT|CHILD|CIRCLE|ELLIPSE|ARC|PARABOLA|BEND
        ;
                        
t_coordinate
        :       COORDINATE t_options* '(' string ')' ( AT multioperator?  '(' ( cs_name=string CS )? t_options* t_list ')' )?
        ->      ^( POINT t_list?  ^( NAME string )? ^( COORD_SYS $cs_name )? t_options? multioperator? )
        |       multioperator? '(' ( cs_name=string CS )? t_options* t_list ')'
        ->      ^( POINT t_list t_options? multioperator? )
        ;               

t_moveto:       t_coordinate
        ->      ^( MOVETO t_coordinate )
        ;


t_lineto:       LINE t_coordinate
        ->      ^( LINETO t_coordinate )
        ;

t_lineto_hv
        :       HVLINE t_coordinate
        ->      ^( LINETOHV t_coordinate )
        ;
        
t_lineto_vh
        :       VHLINE t_coordinate
        ->      ^( LINETOVH t_coordinate )
        ;
        
t_cycle :       LINE CYCLE
        ->      CYCLE
        ;

t_to_path       
        :       TO t_options? t_coordinate
        ->      ^( PATH_CONSTRUCTION t_options? t_coordinate )
        |       TO t_options? NODE t_options? curly_brackets t_coordinate?
        ->      ^( PATH_CONSTRUCTION t_options? ^(NODE t_options? curly_brackets t_coordinate ) )
        ;
/*
t_node  :       NODE t_options* ( '(' string ')' )? t_options* (AT t_coordinate)? t_options* curly_brackets CHILD+ 
        ->      ^(NODE t_options* ^(NAME string)? t_coordinate? curly_brackets  CHILD+)
        ;
*/

t_node  :       NODE t_options* ( '(' string ')')? (AT t_coordinate)? t_options* curly_brackets CHILD*
        ->      ^(NODE t_options* ^(NAME string)? t_coordinate? curly_brackets CHILD*)
                ;
                        
t_child :       CHILD t_options? block=( t_foreach | curly_brackets )?
        ->      ^(CHILD t_options? $block )
        ;

t_foreach
        :       FOREACH  BACKSLASH string IN '{' t_list '}' ( curly_brackets | t_macro )
        ->      ^( FOREACH ^( VARNAME string ) t_list curly_brackets?  t_macro? )
        ;

t_againpath
        :       BACKSLASH AGAINPATH BACKSLASH string
        ->      ^( AGAINPATH ^( NAME string ) )
        ;       
        
t_edge  :       EDGE ( 
                        ( t_options? t_coordinate )
        ->              ^(EDGE t_options?  t_coordinate)
                        | ( t_options? NODE t_options? curly_brackets t_coordinate? ) 
        ->              ^(EDGE t_options? ^(NODE t_options? curly_brackets t_coordinate ) )
                        | (EDGE FROM PARENT t_options)
        ->              ^(EDGE_FROM_PARENT t_options)
                )
        ;
        
t_gird
        :       GRID t_coordinate
        ->      ^(GRID t_coordinate)
        ;
        
t_curve :       DOTS CONTROLS p1=t_coordinate ( AND p2=t_coordinate )? DOTS target=t_coordinate
        ->      ^(CURVE ^(PC $p1) ^(PD $p2)? ^(PE $target))
        ;       
        
t_rectangle
        :       RECTANGLE t_coordinate
        ->      ^(RECTANGLE t_coordinate)
        ;
        
t_grid
        :       GRID t_coordinate
        ->      ^(GRID t_coordinate)
        ;

        
t_parabola
        :       PARABOLA t_options? BEND c1=t_coordinate c2=t_coordinate?
        ->      ^(PARABOLA t_options? $c1 $c2?)
        ;

t_circle:       CIRCLE t_coordinate
        ->      ^( CIRCLE t_coordinate )
        ;
        
t_ellipse
        :       ELLIPSE t_coordinate
        ->      ^( ELLIPSE t_coordinate )
        ;
                
t_arc   :       ARC t_coordinate
        ->      ^( ARC t_coordinate )
        ; 
                
t_plot  :       line=LINE? PLOT (
                        ( COORDINATES '{' t_coordinate* '}')
        ->              ^( PLOT ^( COORDINATES t_coordinate* ) )
                        | ( FILE '{' string '}')
        ->              ^( PLOT ^( FILE string ) )
                        | ( FUNCTION curly_brackets )
        ->              ^( PLOT ^( GNUPLOT curly_brackets ) )
                        | function
        ->              ^( PLOT ^( function ) )
                )
        ;       
        
COMMENT :       '%' (~'\n')* {$channel=HIDDEN; }
        ;
        
BACKSLASH
        :       '\\'
        ;




        
FUNCTION:       'function'
        ;
     
FILE    :       'file'
        ;
        
COORDINATES
        :       'coordinates'
        ;
        
PLOT    :       'plot'
        ;
        
RECTANGLE
        :        'rectangle'
        ;
        
GRID    :        'gird'
        ;
        
LINE    :       '--'
        ;

FROM    :       'from'
        ;
        
PARENT  :       'parent'
        ;
        
HVLINE  :       '-|'
        ;
        

VHLINE  :       '|-'
        ;


DOTS    :       '..'
        ;
        
                
TO      :       'to'
        ;
        
        
IN      :       'in'
        ;
        
        
CS      :       'cs:'
        ;
        
AT      :        'at'
        ;
        
AND     :        'and'
        ;

CYCLE   :       'cycle'
        ;
        
FOREACH :       'foreach'
        ;
        
NODE    :       'node'
        ;
        
EDGE    :       'edge'
        ;
        
CONTROLS:       'controls'
        ;
        

OPERATOR
        :        '<'  | '>' | '=' | '*' | '-' | '+' 
        ;

//MULTI_OPERATOR        :       SINGLE_OPERATOR + ;
        
//  TO_DO div;

CHILD   :       'child'
        ;
        
CIRCLE  :       'circle'
        ;
        
ELLIPSE :       'ellipse'
        ;
        
ARC     :       'arc'
        ;

PARABOLA:       'parabola'
        ;

BEND    :       'bend'
        ;

fragment
OPERATION
        :       'operation'
        ;       
        
fragment
COORD_SYS
        :       'coordinate system'
        ;
        
fragment 
POINT   :       'point';        

/*
fragment
TREE    :       'tree'
        ;
*/
        
fragment 
CURVE   :       'curve'
        ;
        
fragment        
SIN     :       'sin'
        ;
        
fragment        
COS     :       'cos'
        ;
        
FUNC    :       SIN|COS
        ;
        
fragment
AGAINPATH
        :       'againpath'
        ;       

fragment
LINETO  :       'lineto'
        ;

fragment
LINETOHV:       'linetohv'
        ;
        
fragment
LINETOVH:       'linetovh'
        ;

fragment
MOVETO  :       'moveto'
        ;
        
fragment
VARNAME :       'varname'
        ;
                
fragment 
PATH_CONSTRUCTION       
        :       'path'
        ;       

fragment 
GNUPLOT :       'gnuplot'
        ;

fragment 
EDGE_FROM_PARENT
        :       'edge from parent'
        ;

// ----------------- End Of Tikz Macros ---------------
        
BEGIN   :       'begin'
        ;
                
END     :       'end'
        ;

fragment        
MACRO   :       'macro'
        ;
        
fragment        
BODY    :       'body'
        ;
        
fragment
NAME    :       'name'
        ;       
                
fragment
VALUE   :       'value'
        ;

fragment
LIST_ELEM
        :       'list_elem'
        ;
        
fragment
LIST    :       'list'
        ;
        
fragment
LISTS   :       'lists'
        ;
        
fragment
BLOCK   :       'block'
        ;
fragment
BLOCKS  :       'blocks'
        ;
                
fragment
COMMAND :       'command'
        ;

fragment
COMMANDS:       'commands'
        ;       
        
fragment
OPTION  :       'option'
        ;
        
fragment
OPTIONS :       'options'
        ;
        
COORDINATE      
        :       'coordinate'
        ;       

fragment
PC      :       'pc'
        ;

fragment
PD      :       'pd'
        ;
        
fragment
PE      :       'pe'
        ;

fragment
KEYWORDS:       BEGIN|END|HVLINE|VHLINE|BACKSLASH|TO|IN|CYCLE|FOREACH|CS|NODE
                |AT|FUNC|FUNCTION|FILE|COORDINATES|COORDINATE|EDGE|AND|CONTROLS|FROM|PARENT
                |DOTS|RECTANGLE|GRID|PLOT|CHILD|CIRCLE|ELLIPSE|ARC|PARABOLA|BEND|OPERATOR
        ;
        
fragment
CONTROL_CHARS   
        :       '{'|'}'|'('|')'|'['|']'|','|':'|';'|' '|'\t'|'\n'|'\r'
        ;
        

STRING  :       ( ~(KEYWORDS|CONTROL_CHARS) )+
        ;
        

        
WS      :       (' ' | '\t' | '\n' | '\r') {$channel=HIDDEN;}
        ;
