// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g 2010-07-29 17:05:37

 	using GraphToTIKZ;
		using System.Drawing;
		using System.Collections.Generic;
	

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class tikzgrammarParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"DEFINECOLOR", 
		"BEGINTP", 
		"ENDTP", 
		"NODE", 
		"DRAW", 
		"EDGE", 
		"AT", 
		"LPAR", 
		"RPAR", 
		"LBR", 
		"RBR", 
		"LBRR", 
		"RBRR", 
		"KOMMA", 
		"SCALE", 
		"EQU", 
		"SEMIC", 
		"COLON", 
		"STYLESEP", 
		"LABEL", 
		"EVERYLOOP", 
		"ST_INNERSEP", 
		"ST_OUTERSEP", 
		"ST_FILL", 
		"ST_DRAW", 
		"ST_SHAPE", 
		"ST_MINSIZE", 
		"LOOP", 
		"IN", 
		"OUT", 
		"UN_PTS", 
		"UN_CM", 
		"TIKZGRAPH", 
		"ID", 
		"FLOAT", 
		"INT", 
		"EXPONENT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"STRING", 
		"HEX_DIGIT", 
		"UNICODE_ESC", 
		"OCTAL_ESC", 
		"'rgb'", 
		"'--'", 
		"'to'"
    };

    public const int TIKZGRAPH = 36;
    public const int EXPONENT = 40;
    public const int RBR = 14;
    public const int EDGE = 9;
    public const int OCTAL_ESC = 47;
    public const int ST_FILL = 27;
    public const int BEGINTP = 5;
    public const int FLOAT = 38;
    public const int ID = 37;
    public const int EOF = -1;
    public const int LBR = 13;
    public const int AT = 10;
    public const int RBRR = 16;
    public const int ESC_SEQ = 43;
    public const int IN = 32;
    public const int LPAR = 11;
    public const int EVERYLOOP = 24;
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
    public const int STRING = 44;
    public const int DRAW = 8;

    // delegates
    // delegators



        public tikzgrammarParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public tikzgrammarParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        

    override public string[] TokenNames {
		get { return tikzgrammarParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g"; }
    }

     	public TikzGraph tres = new TikzGraph(); 
    		public Dictionary<string, Color> coldefs = new Dictionary<string, Color>();
    	 


    // $ANTLR start "tikzpictopts"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:65:1: tikzpictopts : ( tikzpictopt ( KOMMA tikzpictopt )* )? ;
    public void tikzpictopts() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:66:2: ( ( tikzpictopt ( KOMMA tikzpictopt )* )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:66:4: ( tikzpictopt ( KOMMA tikzpictopt )* )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:66:4: ( tikzpictopt ( KOMMA tikzpictopt )* )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == SCALE || LA2_0 == EVERYLOOP || LA2_0 == ID) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:66:5: tikzpictopt ( KOMMA tikzpictopt )*
            	        {
            	        	PushFollow(FOLLOW_tikzpictopt_in_tikzpictopts355);
            	        	tikzpictopt();
            	        	state.followingStackPointer--;

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:66:17: ( KOMMA tikzpictopt )*
            	        	do 
            	        	{
            	        	    int alt1 = 2;
            	        	    int LA1_0 = input.LA(1);

            	        	    if ( (LA1_0 == KOMMA) )
            	        	    {
            	        	        alt1 = 1;
            	        	    }


            	        	    switch (alt1) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:66:18: KOMMA tikzpictopt
            	        			    {
            	        			    	Match(input,KOMMA,FOLLOW_KOMMA_in_tikzpictopts358); 
            	        			    	PushFollow(FOLLOW_tikzpictopt_in_tikzpictopts360);
            	        			    	tikzpictopt();
            	        			    	state.followingStackPointer--;


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop1;
            	        	    }
            	        	} while (true);

            	        	loop1:
            	        		;	// Stops C# compiler whining that label 'loop1' has no statements


            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "tikzpictopts"


    // $ANTLR start "tikzpicture"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:68:1: tikzpicture : ( colordefs )* BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP ;
    public void tikzpicture() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:69:2: ( ( colordefs )* BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:69:4: ( colordefs )* BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:69:4: ( colordefs )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == DEFINECOLOR) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:69:5: colordefs
            			    {
            			    	PushFollow(FOLLOW_colordefs_in_tikzpicture377);
            			    	colordefs();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	Match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture381); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:69:25: ( LBR tikzpictopts RBR )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == LBR) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:69:26: LBR tikzpictopts RBR
            	        {
            	        	Match(input,LBR,FOLLOW_LBR_in_tikzpicture384); 
            	        	PushFollow(FOLLOW_tikzpictopts_in_tikzpicture386);
            	        	tikzpictopts();
            	        	state.followingStackPointer--;

            	        	Match(input,RBR,FOLLOW_RBR_in_tikzpicture388); 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzbody_in_tikzpicture392);
            	tikzbody();
            	state.followingStackPointer--;

            	Match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture394); 
            	 tres.InferStyleTypes(); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "tikzpicture"


    // $ANTLR start "colordefs"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:71:1: colordefs : DEFINECOLOR LBRR ID RBRR LBRR 'rgb' RBRR LBRR tr= FLOAT KOMMA tg= FLOAT KOMMA tb= FLOAT RBRR ;
    public void colordefs() // throws RecognitionException [1]
    {   
        IToken tr = null;
        IToken tg = null;
        IToken tb = null;
        IToken ID1 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:72:2: ( DEFINECOLOR LBRR ID RBRR LBRR 'rgb' RBRR LBRR tr= FLOAT KOMMA tg= FLOAT KOMMA tb= FLOAT RBRR )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:72:4: DEFINECOLOR LBRR ID RBRR LBRR 'rgb' RBRR LBRR tr= FLOAT KOMMA tg= FLOAT KOMMA tb= FLOAT RBRR
            {
            	Match(input,DEFINECOLOR,FOLLOW_DEFINECOLOR_in_colordefs406); 
            	Match(input,LBRR,FOLLOW_LBRR_in_colordefs408); 
            	ID1=(IToken)Match(input,ID,FOLLOW_ID_in_colordefs410); 
            	Match(input,RBRR,FOLLOW_RBRR_in_colordefs412); 
            	Match(input,LBRR,FOLLOW_LBRR_in_colordefs414); 
            	Match(input,48,FOLLOW_48_in_colordefs416); 
            	Match(input,RBRR,FOLLOW_RBRR_in_colordefs418); 
            	Match(input,LBRR,FOLLOW_LBRR_in_colordefs420); 
            	tr=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_colordefs424); 
            	Match(input,KOMMA,FOLLOW_KOMMA_in_colordefs426); 
            	tg=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_colordefs430); 
            	Match(input,KOMMA,FOLLOW_KOMMA_in_colordefs432); 
            	tb=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_colordefs436); 
            	Match(input,RBRR,FOLLOW_RBRR_in_colordefs438); 
            	 
            				coldefs[((ID1 != null) ? ID1.Text : null)] = Color.FromArgb( Convert.ToInt32(Double.Parse(((tr != null) ? tr.Text : null))*255),
            							 	    Convert.ToInt32(Double.Parse(((tg != null) ? tg.Text : null))*255),
            							 	    Convert.ToInt32(Double.Parse(((tb != null) ? tb.Text : null))*255) ); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "colordefs"


    // $ANTLR start "tikzpictopt"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:77:1: tikzpictopt : ( scaleopt | styledef ) ;
    public void tikzpictopt() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:78:2: ( ( scaleopt | styledef ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:78:4: ( scaleopt | styledef )
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:78:4: ( scaleopt | styledef )
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == SCALE) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == EVERYLOOP || LA5_0 == ID) )
            	{
            	    alt5 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:78:5: scaleopt
            	        {
            	        	PushFollow(FOLLOW_scaleopt_in_tikzpictopt451);
            	        	scaleopt();
            	        	state.followingStackPointer--;


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:78:16: styledef
            	        {
            	        	PushFollow(FOLLOW_styledef_in_tikzpictopt455);
            	        	styledef();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "tikzpictopt"


    // $ANTLR start "scaleopt"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:79:1: scaleopt : SCALE EQU FLOAT ;
    public void scaleopt() // throws RecognitionException [1]
    {   
        IToken FLOAT2 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:80:2: ( SCALE EQU FLOAT )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:80:4: SCALE EQU FLOAT
            {
            	Match(input,SCALE,FOLLOW_SCALE_in_scaleopt465); 
            	Match(input,EQU,FOLLOW_EQU_in_scaleopt467); 
            	FLOAT2=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_scaleopt469); 
            	tres.scale = Double.Parse(((FLOAT2 != null) ? FLOAT2.Text : null));

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "scaleopt"


    // $ANTLR start "styledef"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:82:1: styledef : (tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR ) ;
    public void styledef() // throws RecognitionException [1]
    {   
        IToken tid = null;

         DrawObjectStyle dos = new DrawObjectStyle(); 
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:84:2: ( (tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:84:4: (tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR )
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:84:4: (tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:84:5: tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR
            	{
            		tid = (IToken)input.LT(1);
            		if ( input.LA(1) == EVERYLOOP || input.LA(1) == ID ) 
            		{
            		    input.Consume();
            		    state.errorRecovery = false;
            		}
            		else 
            		{
            		    MismatchedSetException mse = new MismatchedSetException(null,input);
            		    throw mse;
            		}

            		Match(input,STYLESEP,FOLLOW_STYLESEP_in_styledef498); 
            		Match(input,EQU,FOLLOW_EQU_in_styledef500); 
            		Match(input,LBRR,FOLLOW_LBRR_in_styledef502); 
            		PushFollow(FOLLOW_styleopts_in_styledef504);
            		styleopts(dos);
            		state.followingStackPointer--;

            		Match(input,RBRR,FOLLOW_RBRR_in_styledef507); 

            	}

            	 dos.name=((tid != null) ? tid.Text : null); tres.styles[dos.name] = dos; 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "styledef"


    // $ANTLR start "styleopts"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:86:1: styleopts[DrawObjectStyle dos] : ( styleopt[dos] ( KOMMA styleopt[dos] )* )? ;
    public void styleopts(DrawObjectStyle dos) // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:2: ( ( styleopt[dos] ( KOMMA styleopt[dos] )* )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:4: ( styleopt[dos] ( KOMMA styleopt[dos] )* )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:4: ( styleopt[dos] ( KOMMA styleopt[dos] )* )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( ((LA7_0 >= ST_INNERSEP && LA7_0 <= ST_MINSIZE)) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:5: styleopt[dos] ( KOMMA styleopt[dos] )*
            	        {
            	        	PushFollow(FOLLOW_styleopt_in_styleopts523);
            	        	styleopt(dos);
            	        	state.followingStackPointer--;

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:19: ( KOMMA styleopt[dos] )*
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( (LA6_0 == KOMMA) )
            	        	    {
            	        	        alt6 = 1;
            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:20: KOMMA styleopt[dos]
            	        			    {
            	        			    	Match(input,KOMMA,FOLLOW_KOMMA_in_styleopts527); 
            	        			    	PushFollow(FOLLOW_styleopt_in_styleopts529);
            	        			    	styleopt(dos);
            	        			    	state.followingStackPointer--;


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop6;
            	        	    }
            	        	} while (true);

            	        	loop6:
            	        		;	// Stops C# compiler whining that label 'loop6' has no statements


            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "styleopts"


    // $ANTLR start "tikzbody"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:89:1: tikzbody : ( tikznode | tikzedge )* ;
    public void tikzbody() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:2: ( ( tikznode | tikzedge )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:4: ( tikznode | tikzedge )*
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:4: ( tikznode | tikzedge )*
            	do 
            	{
            	    int alt8 = 3;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == NODE) )
            	    {
            	        alt8 = 1;
            	    }
            	    else if ( (LA8_0 == DRAW) )
            	    {
            	        alt8 = 2;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:5: tikznode
            			    {
            			    	PushFollow(FOLLOW_tikznode_in_tikzbody546);
            			    	tikznode();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:16: tikzedge
            			    {
            			    	PushFollow(FOLLOW_tikzedge_in_tikzbody550);
            			    	tikzedge();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "tikzbody"


    // $ANTLR start "styleopt"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:91:1: styleopt[DrawObjectStyle dos] : ( ( ST_INNERSEP EQU INT ( UN_PTS )? ) | ( ST_OUTERSEP EQU INT ( UN_PTS )? ) | ( ST_FILL ( EQU ID )? ) | ( ST_DRAW ( EQU ID )? ) | ST_SHAPE EQU ID | ST_MINSIZE EQU INT ( UN_PTS )? );
    public void styleopt(DrawObjectStyle dos) // throws RecognitionException [1]
    {   
        IToken INT3 = null;
        IToken INT4 = null;
        IToken ID5 = null;
        IToken ID6 = null;
        IToken ID7 = null;
        IToken INT8 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:92:2: ( ( ST_INNERSEP EQU INT ( UN_PTS )? ) | ( ST_OUTERSEP EQU INT ( UN_PTS )? ) | ( ST_FILL ( EQU ID )? ) | ( ST_DRAW ( EQU ID )? ) | ST_SHAPE EQU ID | ST_MINSIZE EQU INT ( UN_PTS )? )
            int alt14 = 6;
            switch ( input.LA(1) ) 
            {
            case ST_INNERSEP:
            	{
                alt14 = 1;
                }
                break;
            case ST_OUTERSEP:
            	{
                alt14 = 2;
                }
                break;
            case ST_FILL:
            	{
                alt14 = 3;
                }
                break;
            case ST_DRAW:
            	{
                alt14 = 4;
                }
                break;
            case ST_SHAPE:
            	{
                alt14 = 5;
                }
                break;
            case ST_MINSIZE:
            	{
                alt14 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            }

            switch (alt14) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:92:4: ( ST_INNERSEP EQU INT ( UN_PTS )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:92:4: ( ST_INNERSEP EQU INT ( UN_PTS )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:92:5: ST_INNERSEP EQU INT ( UN_PTS )?
                    	{
                    		Match(input,ST_INNERSEP,FOLLOW_ST_INNERSEP_in_styleopt563); 
                    		Match(input,EQU,FOLLOW_EQU_in_styleopt565); 
                    		INT3=(IToken)Match(input,INT,FOLLOW_INT_in_styleopt567); 
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:92:25: ( UN_PTS )?
                    		int alt9 = 2;
                    		int LA9_0 = input.LA(1);

                    		if ( (LA9_0 == UN_PTS) )
                    		{
                    		    alt9 = 1;
                    		}
                    		switch (alt9) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:92:25: UN_PTS
                    		        {
                    		        	Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt569); 

                    		        }
                    		        break;

                    		}


                    	}

                    	 dos.innersep = Int32.Parse(((INT3 != null) ? INT3.Text : null)); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:4: ( ST_OUTERSEP EQU INT ( UN_PTS )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:4: ( ST_OUTERSEP EQU INT ( UN_PTS )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:5: ST_OUTERSEP EQU INT ( UN_PTS )?
                    	{
                    		Match(input,ST_OUTERSEP,FOLLOW_ST_OUTERSEP_in_styleopt580); 
                    		Match(input,EQU,FOLLOW_EQU_in_styleopt582); 
                    		INT4=(IToken)Match(input,INT,FOLLOW_INT_in_styleopt584); 
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:25: ( UN_PTS )?
                    		int alt10 = 2;
                    		int LA10_0 = input.LA(1);

                    		if ( (LA10_0 == UN_PTS) )
                    		{
                    		    alt10 = 1;
                    		}
                    		switch (alt10) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:25: UN_PTS
                    		        {
                    		        	Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt586); 

                    		        }
                    		        break;

                    		}


                    	}

                    	 dos.outersep = Int32.Parse(((INT4 != null) ? INT4.Text : null)); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:94:4: ( ST_FILL ( EQU ID )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:94:4: ( ST_FILL ( EQU ID )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:94:5: ST_FILL ( EQU ID )?
                    	{
                    		Match(input,ST_FILL,FOLLOW_ST_FILL_in_styleopt596); 
                    		dos.lfill = true;
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:95:5: ( EQU ID )?
                    		int alt11 = 2;
                    		int LA11_0 = input.LA(1);

                    		if ( (LA11_0 == EQU) )
                    		{
                    		    alt11 = 1;
                    		}
                    		switch (alt11) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:95:6: EQU ID
                    		        {
                    		        	Match(input,EQU,FOLLOW_EQU_in_styleopt605); 
                    		        	ID5=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt607); 
                    		        	dos.fill = DrawObjectStyle.TikzStringToColor(((ID5 != null) ? ID5.Text : null));

                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:96:4: ( ST_DRAW ( EQU ID )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:96:4: ( ST_DRAW ( EQU ID )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:96:5: ST_DRAW ( EQU ID )?
                    	{
                    		Match(input,ST_DRAW,FOLLOW_ST_DRAW_in_styleopt619); 
                    		dos.ldraw = true;
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:97:5: ( EQU ID )?
                    		int alt12 = 2;
                    		int LA12_0 = input.LA(1);

                    		if ( (LA12_0 == EQU) )
                    		{
                    		    alt12 = 1;
                    		}
                    		switch (alt12) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:97:6: EQU ID
                    		        {
                    		        	Match(input,EQU,FOLLOW_EQU_in_styleopt628); 
                    		        	ID6=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt630); 
                    		        	dos.draw = DrawObjectStyle.TikzStringToColor(((ID6 != null) ? ID6.Text : null));

                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 5 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:98:4: ST_SHAPE EQU ID
                    {
                    	Match(input,ST_SHAPE,FOLLOW_ST_SHAPE_in_styleopt640); 
                    	Match(input,EQU,FOLLOW_EQU_in_styleopt642); 
                    	ID7=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt644); 
                    	 dos.shape = (vshape)Enum.Parse(typeof(vshape),((ID7 != null) ? ID7.Text : null)); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:99:4: ST_MINSIZE EQU INT ( UN_PTS )?
                    {
                    	Match(input,ST_MINSIZE,FOLLOW_ST_MINSIZE_in_styleopt651); 
                    	Match(input,EQU,FOLLOW_EQU_in_styleopt653); 
                    	INT8=(IToken)Match(input,INT,FOLLOW_INT_in_styleopt655); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:99:23: ( UN_PTS )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == UN_PTS) )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:99:23: UN_PTS
                    	        {
                    	        	Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt657); 

                    	        }
                    	        break;

                    	}

                    	 dos.minimumsize=Int32.Parse(((INT8 != null) ? INT8.Text : null)); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "styleopt"


    // $ANTLR start "tikznode"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:107:1: tikznode : NODE LPAR ID RPAR ( LBR nodeopts[v] RBR )? AT LPAR tx= number KOMMA ty= number RPAR ( LBR nodeopts[v] RBR )? nodetext[v] SEMIC ;
    public void tikznode() // throws RecognitionException [1]
    {   
        IToken ID9 = null;
        tikzgrammarParser.number_return tx = null;

        tikzgrammarParser.number_return ty = null;


         vertex v = new vertex(); 
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:2: ( NODE LPAR ID RPAR ( LBR nodeopts[v] RBR )? AT LPAR tx= number KOMMA ty= number RPAR ( LBR nodeopts[v] RBR )? nodetext[v] SEMIC )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:4: NODE LPAR ID RPAR ( LBR nodeopts[v] RBR )? AT LPAR tx= number KOMMA ty= number RPAR ( LBR nodeopts[v] RBR )? nodetext[v] SEMIC
            {
            	Match(input,NODE,FOLLOW_NODE_in_tikznode683); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikznode685); 
            	ID9=(IToken)Match(input,ID,FOLLOW_ID_in_tikznode687); 
            	Match(input,RPAR,FOLLOW_RPAR_in_tikznode689); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:22: ( LBR nodeopts[v] RBR )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == LBR) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:23: LBR nodeopts[v] RBR
            	        {
            	        	Match(input,LBR,FOLLOW_LBR_in_tikznode692); 
            	        	PushFollow(FOLLOW_nodeopts_in_tikznode694);
            	        	nodeopts(v);
            	        	state.followingStackPointer--;

            	        	Match(input,RBR,FOLLOW_RBR_in_tikznode697); 

            	        }
            	        break;

            	}

            	Match(input,AT,FOLLOW_AT_in_tikznode701); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikznode703); 
            	PushFollow(FOLLOW_number_in_tikznode707);
            	tx = number();
            	state.followingStackPointer--;

            	Match(input,KOMMA,FOLLOW_KOMMA_in_tikznode709); 
            	PushFollow(FOLLOW_number_in_tikznode713);
            	ty = number();
            	state.followingStackPointer--;

            	Match(input,RPAR,FOLLOW_RPAR_in_tikznode715); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:84: ( LBR nodeopts[v] RBR )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == LBR) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:85: LBR nodeopts[v] RBR
            	        {
            	        	Match(input,LBR,FOLLOW_LBR_in_tikznode718); 
            	        	PushFollow(FOLLOW_nodeopts_in_tikznode720);
            	        	nodeopts(v);
            	        	state.followingStackPointer--;

            	        	Match(input,RBR,FOLLOW_RBR_in_tikznode723); 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_nodetext_in_tikznode727);
            	nodetext(v);
            	state.followingStackPointer--;

            	Match(input,SEMIC,FOLLOW_SEMIC_in_tikznode730); 
            	 v.name = ((ID9 != null) ? ID9.Text : null);
            						 v.x=Double.Parse(((tx != null) ? input.ToString((IToken)(tx.Start),(IToken)(tx.Stop)) : null)); v.y=Double.Parse(((ty != null) ? input.ToString((IToken)(ty.Start),(IToken)(ty.Stop)) : null)); 
            						 tres.AddObject(v);

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "tikznode"


    // $ANTLR start "nodetext"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:113:1: nodetext[vertex v] : LBRR ( ID )? RBRR ;
    public void nodetext(vertex v) // throws RecognitionException [1]
    {   
        IToken ID10 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:114:2: ( LBRR ( ID )? RBRR )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:114:4: LBRR ( ID )? RBRR
            {
            	Match(input,LBRR,FOLLOW_LBRR_in_nodetext744); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:114:9: ( ID )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == ID) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:114:10: ID
            	        {
            	        	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_nodetext747); 
            	        	 v.text = ((ID10 != null) ? ID10.Text : null); 

            	        }
            	        break;

            	}

            	Match(input,RBRR,FOLLOW_RBRR_in_nodetext754); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "nodetext"

    public class number_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "number"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:117:1: number : ( FLOAT | INT ) ;
    public tikzgrammarParser.number_return number() // throws RecognitionException [1]
    {   
        tikzgrammarParser.number_return retval = new tikzgrammarParser.number_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:117:9: ( ( FLOAT | INT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:117:11: ( FLOAT | INT )
            {
            	if ( (input.LA(1) >= FLOAT && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "number"


    // $ANTLR start "nodeopts"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:118:1: nodeopts[vertex v] : nodeopt[v] ( KOMMA nodeopt[v] )* ;
    public void nodeopts(vertex v) // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:119:2: ( nodeopt[v] ( KOMMA nodeopt[v] )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:119:4: nodeopt[v] ( KOMMA nodeopt[v] )*
            {
            	PushFollow(FOLLOW_nodeopt_in_nodeopts780);
            	nodeopt(v);
            	state.followingStackPointer--;

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:119:15: ( KOMMA nodeopt[v] )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == KOMMA) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:119:16: KOMMA nodeopt[v]
            			    {
            			    	Match(input,KOMMA,FOLLOW_KOMMA_in_nodeopts784); 
            			    	PushFollow(FOLLOW_nodeopt_in_nodeopts786);
            			    	nodeopt(v);
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "nodeopts"


    // $ANTLR start "nodeopt"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:121:1: nodeopt[vertex v] : ( ID | LABEL EQU ( INT COLON )? ID );
    public void nodeopt(vertex v) // throws RecognitionException [1]
    {   
        IToken ID11 = null;
        IToken INT12 = null;
        IToken ID13 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:122:2: ( ID | LABEL EQU ( INT COLON )? ID )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == ID) )
            {
                alt20 = 1;
            }
            else if ( (LA20_0 == LABEL) )
            {
                alt20 = 2;
            }
            else 
            {
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:122:4: ID
                    {
                    	ID11=(IToken)Match(input,ID,FOLLOW_ID_in_nodeopt801); 
                    	 v.style = tres.styles[((ID11 != null) ? ID11.Text : null)];	 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:123:4: LABEL EQU ( INT COLON )? ID
                    {
                    	Match(input,LABEL,FOLLOW_LABEL_in_nodeopt809); 
                    	Match(input,EQU,FOLLOW_EQU_in_nodeopt811); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:123:14: ( INT COLON )?
                    	int alt19 = 2;
                    	int LA19_0 = input.LA(1);

                    	if ( (LA19_0 == INT) )
                    	{
                    	    alt19 = 1;
                    	}
                    	switch (alt19) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:123:15: INT COLON
                    	        {
                    	        	INT12=(IToken)Match(input,INT,FOLLOW_INT_in_nodeopt814); 
                    	        	Match(input,COLON,FOLLOW_COLON_in_nodeopt816); 
                    	        	v.labelangle=Int32.Parse(((INT12 != null) ? INT12.Text : null));

                    	        }
                    	        break;

                    	}

                    	ID13=(IToken)Match(input,ID,FOLLOW_ID_in_nodeopt822); 
                    	v.label=((ID13 != null) ? ID13.Text : null); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "nodeopt"


    // $ANTLR start "tikzedge"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:126:1: tikzedge : DRAW LBR edgeopts[ed] RBR LPAR vf= ID RPAR ( '--' | 'to' ) LPAR (vt= ID )? RPAR SEMIC ;
    public void tikzedge() // throws RecognitionException [1]
    {   
        IToken vf = null;
        IToken vt = null;

         edge ed = new edge(); 
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:128:2: ( DRAW LBR edgeopts[ed] RBR LPAR vf= ID RPAR ( '--' | 'to' ) LPAR (vt= ID )? RPAR SEMIC )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:128:4: DRAW LBR edgeopts[ed] RBR LPAR vf= ID RPAR ( '--' | 'to' ) LPAR (vt= ID )? RPAR SEMIC
            {
            	Match(input,DRAW,FOLLOW_DRAW_in_tikzedge844); 
            	Match(input,LBR,FOLLOW_LBR_in_tikzedge846); 
            	PushFollow(FOLLOW_edgeopts_in_tikzedge848);
            	edgeopts(ed);
            	state.followingStackPointer--;

            	Match(input,RBR,FOLLOW_RBR_in_tikzedge851); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikzedge853); 
            	vf=(IToken)Match(input,ID,FOLLOW_ID_in_tikzedge857); 
            	Match(input,RPAR,FOLLOW_RPAR_in_tikzedge859); 
            	if ( (input.LA(1) >= 49 && input.LA(1) <= 50) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	Match(input,LPAR,FOLLOW_LPAR_in_tikzedge867); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:128:63: (vt= ID )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == ID) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:128:64: vt= ID
            	        {
            	        	vt=(IToken)Match(input,ID,FOLLOW_ID_in_tikzedge872); 

            	        }
            	        break;

            	}

            	Match(input,RPAR,FOLLOW_RPAR_in_tikzedge876); 
            	Match(input,SEMIC,FOLLOW_SEMIC_in_tikzedge878); 
            	 
            									  ed.from = tres.vfromname(((vf != null) ? vf.Text : null));
            									  ed.to = tres.vfromname(((vt != null) ? vt.Text : null));
            									  if (ed.to==null) ed.to=ed.from;
            									  tres.AddObject(ed); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "tikzedge"


    // $ANTLR start "edgeopts"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:134:1: edgeopts[edge ed] : edgeopt[ed] ( KOMMA edgeopt[ed] )* ;
    public void edgeopts(edge ed) // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:135:2: ( edgeopt[ed] ( KOMMA edgeopt[ed] )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:135:4: edgeopt[ed] ( KOMMA edgeopt[ed] )*
            {
            	PushFollow(FOLLOW_edgeopt_in_edgeopts891);
            	edgeopt(ed);
            	state.followingStackPointer--;

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:135:16: ( KOMMA edgeopt[ed] )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == KOMMA) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:135:17: KOMMA edgeopt[ed]
            			    {
            			    	Match(input,KOMMA,FOLLOW_KOMMA_in_edgeopts895); 
            			    	PushFollow(FOLLOW_edgeopt_in_edgeopts897);
            			    	edgeopt(ed);
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "edgeopts"


    // $ANTLR start "edgeopt"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:137:1: edgeopt[edge ed] : ( ID | LOOP | IN EQU INT | OUT EQU INT );
    public void edgeopt(edge ed) // throws RecognitionException [1]
    {   
        IToken ID14 = null;
        IToken INT15 = null;
        IToken INT16 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:138:2: ( ID | LOOP | IN EQU INT | OUT EQU INT )
            int alt23 = 4;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt23 = 1;
                }
                break;
            case LOOP:
            	{
                alt23 = 2;
                }
                break;
            case IN:
            	{
                alt23 = 3;
                }
                break;
            case OUT:
            	{
                alt23 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d23s0 =
            	        new NoViableAltException("", 23, 0, input);

            	    throw nvae_d23s0;
            }

            switch (alt23) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:138:4: ID
                    {
                    	ID14=(IToken)Match(input,ID,FOLLOW_ID_in_edgeopt912); 
                    	 ed.style = tres.styles[((ID14 != null) ? ID14.Text : null)]; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:139:4: LOOP
                    {
                    	Match(input,LOOP,FOLLOW_LOOP_in_edgeopt920); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:140:4: IN EQU INT
                    {
                    	Match(input,IN,FOLLOW_IN_in_edgeopt926); 
                    	Match(input,EQU,FOLLOW_EQU_in_edgeopt928); 
                    	INT15=(IToken)Match(input,INT,FOLLOW_INT_in_edgeopt930); 
                    	 ed.inangle=Int32.Parse(((INT15 != null) ? INT15.Text : null)); ed.useinoutangle=true; 

                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:141:4: OUT EQU INT
                    {
                    	Match(input,OUT,FOLLOW_OUT_in_edgeopt937); 
                    	Match(input,EQU,FOLLOW_EQU_in_edgeopt939); 
                    	INT16=(IToken)Match(input,INT,FOLLOW_INT_in_edgeopt941); 
                    	 ed.outangle=Int32.Parse(((INT16 != null) ? INT16.Text : null)); ed.useinoutangle=true; 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "edgeopt"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_tikzpictopt_in_tikzpictopts355 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikzpictopts358 = new BitSet(new ulong[]{0x0000002001040000UL});
    public static readonly BitSet FOLLOW_tikzpictopt_in_tikzpictopts360 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_colordefs_in_tikzpicture377 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_BEGINTP_in_tikzpicture381 = new BitSet(new ulong[]{0x00000000000021C0UL});
    public static readonly BitSet FOLLOW_LBR_in_tikzpicture384 = new BitSet(new ulong[]{0x0000002001044000UL});
    public static readonly BitSet FOLLOW_tikzpictopts_in_tikzpicture386 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikzpicture388 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture392 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ENDTP_in_tikzpicture394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DEFINECOLOR_in_colordefs406 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LBRR_in_colordefs408 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_ID_in_colordefs410 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_colordefs412 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LBRR_in_colordefs414 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_colordefs416 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_colordefs418 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LBRR_in_colordefs420 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_colordefs424 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_colordefs426 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_colordefs430 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_colordefs432 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_colordefs436 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_colordefs438 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scaleopt_in_tikzpictopt451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_styledef_in_tikzpictopt455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SCALE_in_scaleopt465 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_scaleopt467 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_scaleopt469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_styledef490 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_STYLESEP_in_styledef498 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styledef500 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LBRR_in_styledef502 = new BitSet(new ulong[]{0x000000007E010000UL});
    public static readonly BitSet FOLLOW_styleopts_in_styledef504 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_styledef507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_styleopt_in_styleopts523 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_styleopts527 = new BitSet(new ulong[]{0x000000007E000000UL});
    public static readonly BitSet FOLLOW_styleopt_in_styleopts529 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikzbody546 = new BitSet(new ulong[]{0x0000000000000182UL});
    public static readonly BitSet FOLLOW_tikzedge_in_tikzbody550 = new BitSet(new ulong[]{0x0000000000000182UL});
    public static readonly BitSet FOLLOW_ST_INNERSEP_in_styleopt563 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt565 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_INT_in_styleopt567 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_OUTERSEP_in_styleopt580 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt582 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_INT_in_styleopt584 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_FILL_in_styleopt596 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt605 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_DRAW_in_styleopt619 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt628 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_SHAPE_in_styleopt640 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt642 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_MINSIZE_in_styleopt651 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt653 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_INT_in_styleopt655 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt657 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_tikznode683 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikznode685 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_ID_in_tikznode687 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikznode689 = new BitSet(new ulong[]{0x0000000000002400UL});
    public static readonly BitSet FOLLOW_LBR_in_tikznode692 = new BitSet(new ulong[]{0x0000002000800000UL});
    public static readonly BitSet FOLLOW_nodeopts_in_tikznode694 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikznode697 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_AT_in_tikznode701 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikznode703 = new BitSet(new ulong[]{0x000000C000000000UL});
    public static readonly BitSet FOLLOW_number_in_tikznode707 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikznode709 = new BitSet(new ulong[]{0x000000C000000000UL});
    public static readonly BitSet FOLLOW_number_in_tikznode713 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikznode715 = new BitSet(new ulong[]{0x000000000000A000UL});
    public static readonly BitSet FOLLOW_LBR_in_tikznode718 = new BitSet(new ulong[]{0x0000002000800000UL});
    public static readonly BitSet FOLLOW_nodeopts_in_tikznode720 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikznode723 = new BitSet(new ulong[]{0x000000000000A000UL});
    public static readonly BitSet FOLLOW_nodetext_in_tikznode727 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SEMIC_in_tikznode730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRR_in_nodetext744 = new BitSet(new ulong[]{0x0000002000010000UL});
    public static readonly BitSet FOLLOW_ID_in_nodetext747 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_nodetext754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodeopt_in_nodeopts780 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_nodeopts784 = new BitSet(new ulong[]{0x0000002000800000UL});
    public static readonly BitSet FOLLOW_nodeopt_in_nodeopts786 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_ID_in_nodeopt801 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LABEL_in_nodeopt809 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_nodeopt811 = new BitSet(new ulong[]{0x000000A000000000UL});
    public static readonly BitSet FOLLOW_INT_in_nodeopt814 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_COLON_in_nodeopt816 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodeopt822 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DRAW_in_tikzedge844 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LBR_in_tikzedge846 = new BitSet(new ulong[]{0x0000002380000000UL});
    public static readonly BitSet FOLLOW_edgeopts_in_tikzedge848 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikzedge851 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikzedge853 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_ID_in_tikzedge857 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikzedge859 = new BitSet(new ulong[]{0x0006000000000000UL});
    public static readonly BitSet FOLLOW_set_in_tikzedge861 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikzedge867 = new BitSet(new ulong[]{0x0000002000001000UL});
    public static readonly BitSet FOLLOW_ID_in_tikzedge872 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikzedge876 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SEMIC_in_tikzedge878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeopt_in_edgeopts891 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_edgeopts895 = new BitSet(new ulong[]{0x0000002380000000UL});
    public static readonly BitSet FOLLOW_edgeopt_in_edgeopts897 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_ID_in_edgeopt912 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOOP_in_edgeopt920 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IN_in_edgeopt926 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_edgeopt928 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_INT_in_edgeopt930 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OUT_in_edgeopt937 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_edgeopt939 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_INT_in_edgeopt941 = new BitSet(new ulong[]{0x0000000000000002UL});

}
