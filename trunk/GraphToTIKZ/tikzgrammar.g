grammar tikzgrammar;

options {
language = 'CSharp';
//output=AST;
// ASTLabelType=CommonTree;
}

tokens {
	DEFINECOLOR	= '\\definecolor';
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
	EVERYLOOP	= 'every loop';
	
	// styles
	ST_INNERSEP	= 'inner sep';
	ST_OUTERSEP	= 'outer sep';
	ST_FILL		= 'fill';
	ST_DRAW		= 'draw';
	ST_SHAPE	= 'shape';
	ST_MINSIZE	= 'minimum size';
	ST_LINEWIDTH	= 'line width';
	ST_DASHSTYLE	= 'dash style';
	
	// edge option
	LOOP		= 'loop';
	IN		= 'in';
	OUT		= 'out';
	
	// units
	UN_PTS		= 'pt';
	UN_CM		= 'cm';
//	UN_IN		= 'in';

	// pseudo-tokens
	TIKZGRAPH;
}

@header { 	using GraphToTIKZ;
		using System.Drawing;
		using System.Collections.Generic;
	}

@members { 	public TikzGraph tres = new TikzGraph(); 
		public Dictionary<string, Color> coldefs = new Dictionary<string, Color>();
	 }


tikzpictopts
	:	(tikzpictopt (KOMMA tikzpictopt)* )?
	;
tikzpicture 
	:	(colordefs)* BEGINTP (LBR tikzpictopts RBR)? tikzbody ENDTP { //tres.InferStyleTypes();
									      tres.CleanUpAfterParsing(); }
	;
colordefs
	:	DEFINECOLOR LBRR ID RBRR LBRR 'rgb' RBRR LBRR tr=FLOAT KOMMA tg=FLOAT KOMMA tb=FLOAT RBRR { 
			coldefs[$ID.text] = Color.FromArgb( Convert.ToInt32(Double.Parse($tr.text)*255),
						 	    Convert.ToInt32(Double.Parse($tg.text)*255),
						 	    Convert.ToInt32(Double.Parse($tb.text)*255) ); }
	;
tikzpictopt
	:	(scaleopt | styledef);
scaleopt 
	:	SCALE EQU FLOAT	{tres.scale = Double.Parse($FLOAT.text);}
	;
styledef //returns [DrawObjectStyle dos]
@init { DrawObjectStyle dos = new DrawObjectStyle(); }
	:	(tid=(EVERYLOOP | ID) STYLESEP EQU LBRR styleopts[dos] RBRR) { dos.name=$tid.text; tres.styles[dos.name] = dos; }
	;
styleopts [DrawObjectStyle dos]
	:	(styleopt[dos] (KOMMA styleopt[dos])* )?;

tikzbody 
	:	(tikznode | tikzedge)*;
styleopt [DrawObjectStyle dos]
	:	(ST_INNERSEP EQU INT UN_PTS?) { dos.innersep = Int32.Parse($INT.text); dos.type = DOType.V; } 
	|	(ST_OUTERSEP EQU INT UN_PTS?) { dos.outersep = Int32.Parse($INT.text); dos.type = DOType.V; }
	|	(ST_FILL {dos.lfill = true;}
		  (EQU ID {dos.fill = DrawObjectStyle.TikzStringToColor($ID.text);})?) // TODO
	|	(ST_DRAW {dos.ldraw = true;}
		  (EQU ID {dos.draw = DrawObjectStyle.TikzStringToColor($ID.text);})?)
	|	ST_SHAPE EQU ID { dos.shape = (vshape)Enum.Parse(typeof(vshape),$ID.text); dos.type = DOType.V; }
	|	ST_MINSIZE EQU INT UN_PTS? { dos.minimumsize=Int32.Parse($INT.text); dos.type = DOType.V; }
	|	arrowstyleopt[dos]
	|	ST_LINEWIDTH EQU FLOAT UN_PTS? { dos.LineWidth = (float)Double.Parse($FLOAT.text); }
	|	ST_DASHSTYLE EQU ID { dos.dashstyle = Helper.TikzDashStyleFromString($ID.text); }
	;
arrowstyleopt [DrawObjectStyle dos]
	:	'--' { dos.type = DOType.E; }
		| (a1=ARROW)? '-' (a2=ARROW)? { dos.fromTip = Helper.TikzArrowTipFromString($a1.text);
						dos.toTip = Helper.TikzArrowTipFromString($a2.text);
						dos.type = DOType.E; }
	;
//styleval)? ;
//styleid :	(ST_INNERSEP | ST_OUTERSEP | ST_FILL | ST_DRAW);
//styleval:	( number unit? | ID ); // TODO: add support for unknown option	
//unit 	:	(UN_PTS | UN_CM | UN_IN);

	
tikznode 
@init { vertex v = new vertex(); }
	:	NODE LPAR ID RPAR (LBR nodeopts[v] RBR)? AT LPAR tx=number KOMMA ty=number RPAR (LBR nodeopts[v] RBR)? nodetext[v] SEMIC { v.name = $ID.text;
					 v.x=Double.Parse($tx.text); v.y=Double.Parse($ty.text); 
					 tres.AddObject(v);}
	;
nodetext[vertex v]	
	: LBRR (ID { v.text = $ID.text; })?  RBRR
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
@init { edge ed = new edge(); }
	:	DRAW LBR edgeopts[ed] RBR LPAR vf=ID RPAR ('--'|'to') LPAR (vt=ID)? RPAR SEMIC { 
								  ed.from = tres.vfromname($vf.text);
								  ed.to = tres.vfromname($vt.text);
								  if (ed.to==null) 
								  	ed.to=ed.from;
								  tres.AddObject(ed); }
	;
edgeopts[edge ed]
	: edgeopt[ed] (KOMMA edgeopt[ed])*
	;
edgeopt[edge ed] 
	: ID { ed.style = tres.styles[$ID.text]; } // TODO?: add more
	| LOOP	// just ignore
	| IN EQU INT { ed.inangle=Int32.Parse($INT.text); ed.useinoutangle=true; }
	| OUT EQU INT { ed.outangle=Int32.Parse($INT.text); ed.useinoutangle=true; }
	//| LABEL EQU (INT COLON {v.labelangle=Int32.Parse($INT.text);})? ID {v.label=$ID.text; } //TODO 
	;  

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

ARROW 	: '<'|'>'	
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
