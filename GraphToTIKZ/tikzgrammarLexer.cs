// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g 2010-07-29 17:05:37


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class tikzgrammarLexer : Lexer {
    public const int TIKZGRAPH = 36;
    public const int EXPONENT = 40;
    public const int RBR = 14;
    public const int EDGE = 9;
    public const int OCTAL_ESC = 47;
    public const int ST_FILL = 27;
    public const int FLOAT = 38;
    public const int BEGINTP = 5;
    public const int ID = 37;
    public const int EOF = -1;
    public const int LBR = 13;
    public const int AT = 10;
    public const int RBRR = 16;
    public const int ESC_SEQ = 43;
    public const int IN = 32;
    public const int EVERYLOOP = 24;
    public const int LPAR = 11;
    public const int ENDTP = 6;
    public const int LOOP = 31;
    public const int ST_OUTERSEP = 26;
    public const int COMMENT = 41;
    public const int DEFINECOLOR = 4;
    public const int T__50 = 50;
    public const int ST_INNERSEP = 25;
    public const int NODE = 7;
    public const int UN_PTS = 34;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int UNICODE_ESC = 46;
    public const int STYLESEP = 22;
    public const int HEX_DIGIT = 45;
    public const int LBRR = 15;
    public const int INT = 39;
    public const int UN_CM = 35;
    public const int COLON = 21;
    public const int ST_DRAW = 28;
    public const int SCALE = 18;
    public const int WS = 42;
    public const int LABEL = 23;
    public const int ST_MINSIZE = 30;
    public const int OUT = 33;
    public const int KOMMA = 17;
    public const int ST_SHAPE = 29;
    public const int EQU = 19;
    public const int RPAR = 12;
    public const int SEMIC = 20;
    public const int DRAW = 8;
    public const int STRING = 44;

    // delegates
    // delegators

    public tikzgrammarLexer() 
    {
		InitializeCyclicDFAs();
    }
    public tikzgrammarLexer(ICharStream input)
		: this(input, null) {
    }
    public tikzgrammarLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g";} 
    }

    // $ANTLR start "DEFINECOLOR"
    public void mDEFINECOLOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DEFINECOLOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:7:13: ( '\\\\definecolor' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:7:15: '\\\\definecolor'
            {
            	Match("\\definecolor"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DEFINECOLOR"

    // $ANTLR start "BEGINTP"
    public void mBEGINTP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGINTP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:8:9: ( '\\\\begin{tikzpicture}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:8:11: '\\\\begin{tikzpicture}'
            {
            	Match("\\begin{tikzpicture}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BEGINTP"

    // $ANTLR start "ENDTP"
    public void mENDTP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDTP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:9:7: ( '\\\\end{tikzpicture}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:9:9: '\\\\end{tikzpicture}'
            {
            	Match("\\end{tikzpicture}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDTP"

    // $ANTLR start "NODE"
    public void mNODE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NODE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:10:6: ( '\\\\node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:10:8: '\\\\node'
            {
            	Match("\\node"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NODE"

    // $ANTLR start "DRAW"
    public void mDRAW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DRAW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:11:6: ( '\\\\draw' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:11:8: '\\\\draw'
            {
            	Match("\\draw"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DRAW"

    // $ANTLR start "EDGE"
    public void mEDGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EDGE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:12:6: ( 'edge' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:12:8: 'edge'
            {
            	Match("edge"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EDGE"

    // $ANTLR start "AT"
    public void mAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:13:4: ( 'at' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:13:6: 'at'
            {
            	Match("at"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AT"

    // $ANTLR start "LPAR"
    public void mLPAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:14:6: ( '(' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:14:8: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LPAR"

    // $ANTLR start "RPAR"
    public void mRPAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RPAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:15:6: ( ')' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:15:8: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RPAR"

    // $ANTLR start "LBR"
    public void mLBR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:16:5: ( '[' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:16:7: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LBR"

    // $ANTLR start "RBR"
    public void mRBR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:17:5: ( ']' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:17:7: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RBR"

    // $ANTLR start "LBRR"
    public void mLBRR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:18:6: ( '{' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:18:8: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LBRR"

    // $ANTLR start "RBRR"
    public void mRBRR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:19:6: ( '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:19:8: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RBRR"

    // $ANTLR start "KOMMA"
    public void mKOMMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = KOMMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:20:7: ( ',' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:20:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "KOMMA"

    // $ANTLR start "SCALE"
    public void mSCALE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SCALE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:21:7: ( 'scale' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:21:9: 'scale'
            {
            	Match("scale"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SCALE"

    // $ANTLR start "EQU"
    public void mEQU() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQU;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:22:5: ( '=' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:22:7: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQU"

    // $ANTLR start "SEMIC"
    public void mSEMIC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEMIC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:23:7: ( ';' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:23:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEMIC"

    // $ANTLR start "COLON"
    public void mCOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:24:7: ( ':' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:24:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLON"

    // $ANTLR start "STYLESEP"
    public void mSTYLESEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STYLESEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:25:10: ( '/.style' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:25:12: '/.style'
            {
            	Match("/.style"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STYLESEP"

    // $ANTLR start "LABEL"
    public void mLABEL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LABEL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:26:7: ( 'label' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:26:9: 'label'
            {
            	Match("label"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LABEL"

    // $ANTLR start "EVERYLOOP"
    public void mEVERYLOOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EVERYLOOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:27:11: ( 'every loop' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:27:13: 'every loop'
            {
            	Match("every loop"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EVERYLOOP"

    // $ANTLR start "ST_INNERSEP"
    public void mST_INNERSEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_INNERSEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:28:13: ( 'inner sep' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:28:15: 'inner sep'
            {
            	Match("inner sep"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_INNERSEP"

    // $ANTLR start "ST_OUTERSEP"
    public void mST_OUTERSEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_OUTERSEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:29:13: ( 'outer sep' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:29:15: 'outer sep'
            {
            	Match("outer sep"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_OUTERSEP"

    // $ANTLR start "ST_FILL"
    public void mST_FILL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_FILL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:30:9: ( 'fill' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:30:11: 'fill'
            {
            	Match("fill"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_FILL"

    // $ANTLR start "ST_DRAW"
    public void mST_DRAW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_DRAW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:31:9: ( 'draw' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:31:11: 'draw'
            {
            	Match("draw"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_DRAW"

    // $ANTLR start "ST_SHAPE"
    public void mST_SHAPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_SHAPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:32:10: ( 'shape' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:32:12: 'shape'
            {
            	Match("shape"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_SHAPE"

    // $ANTLR start "ST_MINSIZE"
    public void mST_MINSIZE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_MINSIZE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:33:12: ( 'minimum size' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:33:14: 'minimum size'
            {
            	Match("minimum size"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_MINSIZE"

    // $ANTLR start "LOOP"
    public void mLOOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LOOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:34:6: ( 'loop' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:34:8: 'loop'
            {
            	Match("loop"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LOOP"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:35:4: ( 'in' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:35:6: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "OUT"
    public void mOUT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OUT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:36:5: ( 'out' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:36:7: 'out'
            {
            	Match("out"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OUT"

    // $ANTLR start "UN_PTS"
    public void mUN_PTS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UN_PTS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:37:8: ( 'pt' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:37:10: 'pt'
            {
            	Match("pt"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UN_PTS"

    // $ANTLR start "UN_CM"
    public void mUN_CM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UN_CM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:38:7: ( 'cm' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:38:9: 'cm'
            {
            	Match("cm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UN_CM"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:39:7: ( 'rgb' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:39:9: 'rgb'
            {
            	Match("rgb"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:40:7: ( '--' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:40:9: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:41:7: ( 'to' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:41:9: 'to'
            {
            	Match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:145:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:145:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:145:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:148:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:148:7: ( '0' .. '9' )+
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:148:7: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:148:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT"
    public void mFLOAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FLOAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT )
            int alt9 = 3;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )?
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:9: ( '0' .. '9' )+
                    	int cnt3 = 0;
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt3 >= 1 ) goto loop3;
                    		            EarlyExitException eee3 =
                    		                new EarlyExitException(3, input);
                    		            throw eee3;
                    	    }
                    	    cnt3++;
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements

                    	Match('.'); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:25: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:37: ( EXPONENT )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == 'E' || LA5_0 == 'e') )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:37: EXPONENT
                    	        {
                    	        	mEXPONENT(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:153:9: '.' ( '0' .. '9' )+ ( EXPONENT )?
                    {
                    	Match('.'); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:153:13: ( '0' .. '9' )+
                    	int cnt6 = 0;
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:153:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt6 >= 1 ) goto loop6;
                    		            EarlyExitException eee6 =
                    		                new EarlyExitException(6, input);
                    		            throw eee6;
                    	    }
                    	    cnt6++;
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:153:25: ( EXPONENT )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == 'E' || LA7_0 == 'e') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:153:25: EXPONENT
                    	        {
                    	        	mEXPONENT(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:154:9: ( '0' .. '9' )+ EXPONENT
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:154:9: ( '0' .. '9' )+
                    	int cnt8 = 0;
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:154:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt8 >= 1 ) goto loop8;
                    		            EarlyExitException eee8 =
                    		                new EarlyExitException(8, input);
                    		            throw eee8;
                    	    }
                    	    cnt8++;
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements

                    	mEXPONENT(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FLOAT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:158:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == '/') )
            {
                int LA13_1 = input.LA(2);

                if ( (LA13_1 == '/') )
                {
                    alt13 = 1;
                }
                else if ( (LA13_1 == '*') )
                {
                    alt13 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d13s1 =
                        new NoViableAltException("", 13, 1, input);

                    throw nvae_d13s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:158:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:158:14: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( ((LA10_0 >= '\u0000' && LA10_0 <= '\t') || (LA10_0 >= '\u000B' && LA10_0 <= '\f') || (LA10_0 >= '\u000E' && LA10_0 <= '\uFFFF')) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:158:14: ~ ( '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop10;
                    	    }
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:158:28: ( '\\r' )?
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( (LA11_0 == '\r') )
                    	{
                    	    alt11 = 1;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:158:28: '\\r'
                    	        {
                    	        	Match('\r'); 

                    	        }
                    	        break;

                    	}

                    	Match('\n'); 
                    	_channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:159:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:159:14: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( (LA12_0 == '*') )
                    	    {
                    	        int LA12_1 = input.LA(2);

                    	        if ( (LA12_1 == '/') )
                    	        {
                    	            alt12 = 2;
                    	        }
                    	        else if ( ((LA12_1 >= '\u0000' && LA12_1 <= '.') || (LA12_1 >= '0' && LA12_1 <= '\uFFFF')) )
                    	        {
                    	            alt12 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA12_0 >= '\u0000' && LA12_0 <= ')') || (LA12_0 >= '+' && LA12_0 <= '\uFFFF')) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:159:42: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop12;
                    	    }
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whining that label 'loop12' has no statements

                    	Match("*/"); 

                    	_channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:162:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:162:9: ( ' ' | '\\t' | '\\r' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:170:5: ( '\"' ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )* '\"' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:170:8: '\"' ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:170:12: ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )*
            	do 
            	{
            	    int alt14 = 3;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == '\\') )
            	    {
            	        alt14 = 1;
            	    }
            	    else if ( ((LA14_0 >= '\u0000' && LA14_0 <= '!') || (LA14_0 >= '#' && LA14_0 <= '[') || (LA14_0 >= ']' && LA14_0 <= '\uFFFF')) )
            	    {
            	        alt14 = 2;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:170:14: ESC_SEQ
            			    {
            			    	mESC_SEQ(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:170:24: ~ ( '\\\\' | '\"' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "EXPONENT"
    public void mEXPONENT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:174:10: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:174:12: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
            {
            	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:174:22: ( '+' | '-' )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == '+' || LA15_0 == '-') )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:174:33: ( '0' .. '9' )+
            	int cnt16 = 0;
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= '0' && LA16_0 <= '9')) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:174:34: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt16 >= 1 ) goto loop16;
            		            EarlyExitException eee16 =
            		                new EarlyExitException(16, input);
            		            throw eee16;
            	    }
            	    cnt16++;
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXPONENT"

    // $ANTLR start "HEX_DIGIT"
    public void mHEX_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:177:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:177:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "ESC_SEQ"
    public void mESC_SEQ() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:181:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UNICODE_ESC | OCTAL_ESC )
            int alt17 = 3;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == '\\') )
            {
                switch ( input.LA(2) ) 
                {
                case '\"':
                case '\'':
                case '\\':
                case 'b':
                case 'f':
                case 'n':
                case 'r':
                case 't':
                	{
                    alt17 = 1;
                    }
                    break;
                case 'u':
                	{
                    alt17 = 2;
                    }
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                	{
                    alt17 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d17s1 =
                	        new NoViableAltException("", 17, 1, input);

                	    throw nvae_d17s1;
                }

            }
            else 
            {
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:181:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
                    {
                    	Match('\\'); 
                    	if ( input.LA(1) == '\"' || input.LA(1) == '\'' || input.LA(1) == '\\' || input.LA(1) == 'b' || input.LA(1) == 'f' || input.LA(1) == 'n' || input.LA(1) == 'r' || input.LA(1) == 't' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:182:9: UNICODE_ESC
                    {
                    	mUNICODE_ESC(); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:183:9: OCTAL_ESC
                    {
                    	mOCTAL_ESC(); 

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ESC_SEQ"

    // $ANTLR start "OCTAL_ESC"
    public void mOCTAL_ESC() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:188:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt18 = 3;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == '\\') )
            {
                int LA18_1 = input.LA(2);

                if ( ((LA18_1 >= '0' && LA18_1 <= '3')) )
                {
                    int LA18_2 = input.LA(3);

                    if ( ((LA18_2 >= '0' && LA18_2 <= '7')) )
                    {
                        int LA18_4 = input.LA(4);

                        if ( ((LA18_4 >= '0' && LA18_4 <= '7')) )
                        {
                            alt18 = 1;
                        }
                        else 
                        {
                            alt18 = 2;}
                    }
                    else 
                    {
                        alt18 = 3;}
                }
                else if ( ((LA18_1 >= '4' && LA18_1 <= '7')) )
                {
                    int LA18_3 = input.LA(3);

                    if ( ((LA18_3 >= '0' && LA18_3 <= '7')) )
                    {
                        alt18 = 2;
                    }
                    else 
                    {
                        alt18 = 3;}
                }
                else 
                {
                    NoViableAltException nvae_d18s1 =
                        new NoViableAltException("", 18, 1, input);

                    throw nvae_d18s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:188:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:188:14: ( '0' .. '3' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:188:15: '0' .. '3'
                    	{
                    		MatchRange('0','3'); 

                    	}

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:188:25: ( '0' .. '7' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:188:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:188:36: ( '0' .. '7' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:188:37: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:189:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:189:14: ( '0' .. '7' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:189:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:189:25: ( '0' .. '7' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:189:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:190:9: '\\\\' ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:190:14: ( '0' .. '7' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:190:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OCTAL_ESC"

    // $ANTLR start "UNICODE_ESC"
    public void mUNICODE_ESC() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:195:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:195:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
            {
            	Match('\\'); 
            	Match('u'); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNICODE_ESC"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:8: ( DEFINECOLOR | BEGINTP | ENDTP | NODE | DRAW | EDGE | AT | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | SCALE | EQU | SEMIC | COLON | STYLESEP | LABEL | EVERYLOOP | ST_INNERSEP | ST_OUTERSEP | ST_FILL | ST_DRAW | ST_SHAPE | ST_MINSIZE | LOOP | IN | OUT | UN_PTS | UN_CM | T__48 | T__49 | T__50 | ID | INT | FLOAT | COMMENT | WS | STRING )
        int alt19 = 41;
        alt19 = dfa19.Predict(input);
        switch (alt19) 
        {
            case 1 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:10: DEFINECOLOR
                {
                	mDEFINECOLOR(); 

                }
                break;
            case 2 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:22: BEGINTP
                {
                	mBEGINTP(); 

                }
                break;
            case 3 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:30: ENDTP
                {
                	mENDTP(); 

                }
                break;
            case 4 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:36: NODE
                {
                	mNODE(); 

                }
                break;
            case 5 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:41: DRAW
                {
                	mDRAW(); 

                }
                break;
            case 6 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:46: EDGE
                {
                	mEDGE(); 

                }
                break;
            case 7 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:51: AT
                {
                	mAT(); 

                }
                break;
            case 8 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:54: LPAR
                {
                	mLPAR(); 

                }
                break;
            case 9 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:59: RPAR
                {
                	mRPAR(); 

                }
                break;
            case 10 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:64: LBR
                {
                	mLBR(); 

                }
                break;
            case 11 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:68: RBR
                {
                	mRBR(); 

                }
                break;
            case 12 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:72: LBRR
                {
                	mLBRR(); 

                }
                break;
            case 13 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:77: RBRR
                {
                	mRBRR(); 

                }
                break;
            case 14 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:82: KOMMA
                {
                	mKOMMA(); 

                }
                break;
            case 15 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:88: SCALE
                {
                	mSCALE(); 

                }
                break;
            case 16 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:94: EQU
                {
                	mEQU(); 

                }
                break;
            case 17 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:98: SEMIC
                {
                	mSEMIC(); 

                }
                break;
            case 18 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:104: COLON
                {
                	mCOLON(); 

                }
                break;
            case 19 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:110: STYLESEP
                {
                	mSTYLESEP(); 

                }
                break;
            case 20 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:119: LABEL
                {
                	mLABEL(); 

                }
                break;
            case 21 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:125: EVERYLOOP
                {
                	mEVERYLOOP(); 

                }
                break;
            case 22 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:135: ST_INNERSEP
                {
                	mST_INNERSEP(); 

                }
                break;
            case 23 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:147: ST_OUTERSEP
                {
                	mST_OUTERSEP(); 

                }
                break;
            case 24 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:159: ST_FILL
                {
                	mST_FILL(); 

                }
                break;
            case 25 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:167: ST_DRAW
                {
                	mST_DRAW(); 

                }
                break;
            case 26 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:175: ST_SHAPE
                {
                	mST_SHAPE(); 

                }
                break;
            case 27 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:184: ST_MINSIZE
                {
                	mST_MINSIZE(); 

                }
                break;
            case 28 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:195: LOOP
                {
                	mLOOP(); 

                }
                break;
            case 29 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:200: IN
                {
                	mIN(); 

                }
                break;
            case 30 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:203: OUT
                {
                	mOUT(); 

                }
                break;
            case 31 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:207: UN_PTS
                {
                	mUN_PTS(); 

                }
                break;
            case 32 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:214: UN_CM
                {
                	mUN_CM(); 

                }
                break;
            case 33 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:220: T__48
                {
                	mT__48(); 

                }
                break;
            case 34 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:226: T__49
                {
                	mT__49(); 

                }
                break;
            case 35 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:232: T__50
                {
                	mT__50(); 

                }
                break;
            case 36 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:238: ID
                {
                	mID(); 

                }
                break;
            case 37 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:241: INT
                {
                	mINT(); 

                }
                break;
            case 38 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:245: FLOAT
                {
                	mFLOAT(); 

                }
                break;
            case 39 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:251: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 40 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:259: WS
                {
                	mWS(); 

                }
                break;
            case 41 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:1:262: STRING
                {
                	mSTRING(); 

                }
                break;

        }

    }


    protected DFA9 dfa9;
    protected DFA19 dfa19;
	private void InitializeCyclicDFAs()
	{
	    this.dfa9 = new DFA9(this);
	    this.dfa19 = new DFA19(this);
	}

    const string DFA9_eotS =
        "\x05\uffff";
    const string DFA9_eofS =
        "\x05\uffff";
    const string DFA9_minS =
        "\x02\x2e\x03\uffff";
    const string DFA9_maxS =
        "\x01\x39\x01\x65\x03\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x01";
    const string DFA9_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x04\x01\uffff\x0a\x01\x0b\uffff\x01\x03\x1f\uffff\x01"+
            "\x03",
            "",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "151:1: FLOAT : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT );"; }
        }

    }

    const string DFA19_eotS =
        "\x02\uffff\x02\x1b\x07\uffff\x01\x1b\x04\uffff\x09\x1b\x01\uffff"+
        "\x01\x1b\x01\uffff\x01\x36\x07\uffff\x02\x1b\x01\x3b\x02\x1b\x02"+
        "\uffff\x02\x1b\x01\x41\x04\x1b\x01\x46\x01\x47\x01\x1b\x01\x49\x03"+
        "\uffff\x02\x1b\x01\uffff\x05\x1b\x01\uffff\x01\x52\x03\x1b\x02\uffff"+
        "\x01\x56\x01\uffff\x01\x57\x04\x1b\x01\x5c\x02\x1b\x01\uffff\x01"+
        "\x5f\x01\x60\x01\x1b\x02\uffff\x01\x1b\x01\x63\x01\x64\x01\x65\x01"+
        "\uffff\x02\x1b\x02\uffff\x01\x1b\x06\uffff\x02\x1b\x01\uffff";
    const string DFA19_eofS =
        "\x6b\uffff";
    const string DFA19_minS =
        "\x01\x09\x01\x62\x01\x64\x01\x74\x07\uffff\x01\x63\x03\uffff\x01"+
        "\x2a\x01\x61\x01\x6e\x01\x75\x01\x69\x01\x72\x01\x69\x01\x74\x01"+
        "\x6d\x01\x67\x01\uffff\x01\x6f\x01\uffff\x01\x2e\x03\uffff\x01\x65"+
        "\x03\uffff\x01\x67\x01\x65\x01\x30\x02\x61\x02\uffff\x01\x62\x01"+
        "\x6f\x01\x30\x01\x74\x01\x6c\x01\x61\x01\x6e\x02\x30\x01\x62\x01"+
        "\x30\x03\uffff\x01\x65\x01\x72\x01\uffff\x01\x6c\x01\x70\x01\x65"+
        "\x01\x70\x01\x65\x01\uffff\x01\x30\x01\x6c\x01\x77\x01\x69\x02\uffff"+
        "\x01\x30\x01\uffff\x01\x30\x01\x79\x02\x65\x01\x6c\x01\x30\x02\x72"+
        "\x01\uffff\x02\x30\x01\x6d\x02\uffff\x01\x20\x03\x30\x01\uffff\x02"+
        "\x20\x02\uffff\x01\x75\x06\uffff\x01\x6d\x01\x20\x01\uffff";
    const string DFA19_maxS =
        "\x01\x7d\x01\x6e\x01\x76\x01\x74\x07\uffff\x01\x68\x03\uffff\x01"+
        "\x2f\x01\x6f\x01\x6e\x01\x75\x01\x69\x01\x72\x01\x69\x01\x74\x01"+
        "\x6d\x01\x67\x01\uffff\x01\x6f\x01\uffff\x01\x65\x03\uffff\x01\x72"+
        "\x03\uffff\x01\x67\x01\x65\x01\x7a\x02\x61\x02\uffff\x01\x62\x01"+
        "\x6f\x01\x7a\x01\x74\x01\x6c\x01\x61\x01\x6e\x02\x7a\x01\x62\x01"+
        "\x7a\x03\uffff\x01\x65\x01\x72\x01\uffff\x01\x6c\x01\x70\x01\x65"+
        "\x01\x70\x01\x65\x01\uffff\x01\x7a\x01\x6c\x01\x77\x01\x69\x02\uffff"+
        "\x01\x7a\x01\uffff\x01\x7a\x01\x79\x02\x65\x01\x6c\x01\x7a\x02\x72"+
        "\x01\uffff\x02\x7a\x01\x6d\x02\uffff\x01\x20\x03\x7a\x01\uffff\x02"+
        "\x20\x02\uffff\x01\x75\x06\uffff\x01\x6d\x01\x20\x01\uffff";
    const string DFA19_acceptS =
        "\x04\uffff\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\uffff\x01\x10\x01\x11\x01\x12\x0a\uffff\x01\x22\x01\uffff"+
        "\x01\x24\x01\uffff\x01\x26\x01\x28\x01\x29\x01\uffff\x01\x02\x01"+
        "\x03\x01\x04\x05\uffff\x01\x13\x01\x27\x0b\uffff\x01\x25\x01\x01"+
        "\x01\x05\x02\uffff\x01\x07\x05\uffff\x01\x1d\x04\uffff\x01\x1f\x01"+
        "\x20\x01\uffff\x01\x23\x08\uffff\x01\x1e\x03\uffff\x01\x21\x01\x06"+
        "\x04\uffff\x01\x1c\x02\uffff\x01\x18\x01\x19\x01\uffff\x01\x15\x01"+
        "\x0f\x01\x1a\x01\x14\x01\x16\x01\x17\x02\uffff\x01\x1b";
    const string DFA19_specialS =
        "\x6b\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x02\x1e\x02\uffff\x01\x1e\x12\uffff\x01\x1e\x01\uffff\x01"+
            "\x1f\x05\uffff\x01\x04\x01\x05\x02\uffff\x01\x0a\x01\x19\x01"+
            "\x1d\x01\x0f\x0a\x1c\x01\x0e\x01\x0d\x01\uffff\x01\x0c\x03\uffff"+
            "\x1a\x1b\x01\x06\x01\x01\x01\x07\x01\uffff\x01\x1b\x01\uffff"+
            "\x01\x03\x01\x1b\x01\x17\x01\x14\x01\x02\x01\x13\x02\x1b\x01"+
            "\x11\x02\x1b\x01\x10\x01\x15\x01\x1b\x01\x12\x01\x16\x01\x1b"+
            "\x01\x18\x01\x0b\x01\x1a\x06\x1b\x01\x08\x01\uffff\x01\x09",
            "\x01\x21\x01\uffff\x01\x20\x01\x22\x08\uffff\x01\x23",
            "\x01\x24\x11\uffff\x01\x25",
            "\x01\x26",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x27\x04\uffff\x01\x28",
            "",
            "",
            "",
            "\x01\x2a\x03\uffff\x01\x29\x01\x2a",
            "\x01\x2b\x0d\uffff\x01\x2c",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x2f",
            "\x01\x30",
            "\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34",
            "",
            "\x01\x35",
            "",
            "\x01\x1d\x01\uffff\x0a\x1c\x0b\uffff\x01\x1d\x1f\uffff\x01"+
            "\x1d",
            "",
            "",
            "",
            "\x01\x37\x0c\uffff\x01\x38",
            "",
            "",
            "",
            "\x01\x39",
            "\x01\x3a",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x3c",
            "\x01\x3d",
            "",
            "",
            "\x01\x3e",
            "\x01\x3f",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x0d"+
            "\x1b\x01\x40\x0c\x1b",
            "\x01\x42",
            "\x01\x43",
            "\x01\x44",
            "\x01\x45",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x48",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "",
            "",
            "\x01\x4a",
            "\x01\x4b",
            "",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f",
            "\x01\x50",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x04"+
            "\x1b\x01\x51\x15\x1b",
            "\x01\x53",
            "\x01\x54",
            "\x01\x55",
            "",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x5d",
            "\x01\x5e",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x61",
            "",
            "",
            "\x01\x62",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "\x01\x66",
            "\x01\x67",
            "",
            "",
            "\x01\x68",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x69",
            "\x01\x6a",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( DEFINECOLOR | BEGINTP | ENDTP | NODE | DRAW | EDGE | AT | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | SCALE | EQU | SEMIC | COLON | STYLESEP | LABEL | EVERYLOOP | ST_INNERSEP | ST_OUTERSEP | ST_FILL | ST_DRAW | ST_SHAPE | ST_MINSIZE | LOOP | IN | OUT | UN_PTS | UN_CM | T__48 | T__49 | T__50 | ID | INT | FLOAT | COMMENT | WS | STRING );"; }
        }

    }

 
    
}
