grammar tikzgrammar;

options {
language = 'CSharp';
//output=AST;
// ASTLabelType=CommonTree;
}

tokens {
	BEGINTP 	= '\\begin{tikzpicture}';
	ENDTP 		= '\\end{tikzpicture}';
	NODE		= '\\node';
	DRAW		= '\\draw';
	EDGE		= 'edge';
	AT		= 'at';
	LPAR		= '(';
	RPAR		= ')';
	LBR		= '[';
	RBR		= ']';
	LBRR		= '{';
	RBRR		= '}';
	KOMMA		= ',';
	SCALE		= 'scale';
	EQU		= '=';
	SEMIC		= ';';
	COLON		= ':';
	STYLESEP	= '/.style';
	AT		= 'at';
	LABEL		= 'label';
	
	// styles
	ST_INNERSEP	= 'inner sep';
	ST_OUTERSEP	= 'outer sep';
	ST_FILL		= 'fill';
	ST_DRAW		= 'draw';
	ST_SHAPE	= 'shape';
	
	// units
	UN_PTS		= 'pt';
	UN_CM		= 'cm';
	UN_IN		= 'in';

	// pseudo-tokens
	TIKZGRAPH;
}

@header { using GraphToTIKZ; }

@members { public TikzGraph tres = new TikzGraph(); }


tikzpictopts
	:	(tikzpictopt (KOMMA tikzpictopt)* )?
	;
tikzpicture 
	:	BEGINTP (LBR tikzpictopts RBR)? tikzbody ENDTP
	;
tikzpictopt
	:	(scaleopt | styledef);
scaleopt 
	:	SCALE EQU FLOAT	{tres.scale = Double.Parse($FLOAT.text);}
	;
styledef //returns [DrawObjectStyle dos]
@init { DrawObjectStyle dos = new DrawObjectStyle(); }
	:	(ID STYLESEP EQU LBRR styleopts[dos] RBRR) { dos.name=$ID.text; tres.styles.Add(dos.name, dos); }
	;
styleopts [DrawObjectStyle dos]
	:	(styleopt[dos] (KOMMA styleopt[dos])* )?;

tikzbody 
	:	(tikznode | tikzedge)*;
styleopt [DrawObjectStyle dos]
	:	(ST_INNERSEP EQU INT UN_PTS) { dos.innersep = Int32.Parse($INT.text); } 
	|	(ST_OUTERSEP EQU INT UN_PTS) { dos.outersep = Int32.Parse($INT.text); }
	|	(ST_FILL {dos.lfill = true;}
		  (EQU ID {dos.fill = DrawObjectStyle.TikzStringToColor($ID.text);})?) // TODO
	|	(ST_DRAW {dos.ldraw = true;}
		  (EQU ID {dos.draw = DrawObjectStyle.TikzStringToColor($ID.text);})?)
	|	ST_SHAPE EQU ID { dos.shape = (vshape)Enum.Parse(typeof(vshape),$ID.text); }
	;
//styleval)? ;
//styleid :	(ST_INNERSEP | ST_OUTERSEP | ST_FILL | ST_DRAW);
//styleval:	( number unit? | ID ); // TODO: add support for unknown option	
//unit 	:	(UN_PTS | UN_CM | UN_IN);

	
tikznode 
@init { vertex v = new vertex(); v.id = tres.idcnt++; }
	:	NODE LPAR ID RPAR (LBR nodeopts[v] RBR) AT LPAR tx=number KOMMA ty=number RPAR nodetext SEMIC { v.name = $ID.text;
					 v.text=$nodetext.text; v.x=Double.Parse($tx.text); v.y=Double.Parse($ty.text); 
					 tres.objlist.Add(v.id,v);}
	;
nodetext	
	: LBRR (.*) RBRR 
	;

number 	:	(FLOAT | INT);
nodeopts[vertex v]
	: nodeopt[v] (KOMMA nodeopt[v])*
	;
nodeopt[vertex v] 
	: ID { v.style = tres.styles[$ID.text];	 } // TODO?: add more
	| LABEL EQU (INT COLON {v.labelangle=Int32.Parse($INT.text);})? ID {v.label=$ID.text; } //TODO 
	;  

tikzedge 
@init { edge ed = new edge(); ed.id = tres.idcnt++;}
	:	DRAW LPAR vf=ID RPAR '--' LPAR vt=ID RPAR SEMIC { ed.from = tres.vfromname($vf.text);
								  ed.to = tres.vfromname($vt.text); 
								  tres.objlist.Add(ed.id,ed); }
	;

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

INT :	'0'..'9'+
    ;

FLOAT
    :   ('0'..'9')+ '.' ('0'..'9')* EXPONENT?
    |   '.' ('0'..'9')+ EXPONENT?
    |   ('0'..'9')+ EXPONENT
    ; // TODO: what about negative numbers?

COMMENT
    :   '//' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}
    |   '/*' ( options {greedy=false;} : . )* '*/' {$channel=HIDDEN;}
    ;

WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=HIDDEN;}
    ;

STRING
    :  '"' ( ESC_SEQ | ~('\\'|'"') )* '"'
    ;

fragment
EXPONENT : ('e'|'E') ('+'|'-')? ('0'..'9')+ ;

fragment
HEX_DIGIT : ('0'..'9'|'a'..'f'|'A'..'F') ;

fragment
ESC_SEQ
    :   '\\' ('b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
    |   UNICODE_ESC
    |   OCTAL_ESC
    ;

fragment
OCTAL_ESC
    :   '\\' ('0'..'3') ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7')
    ;

fragment
UNICODE_ESC
    :   '\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
    ;
