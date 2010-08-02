// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g 2010-07-29 19:22:21

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
		"ST_LINEWIDTH", 
		"ST_DASHSTYLE", 
		"LOOP", 
		"IN", 
		"OUT", 
		"UN_PTS", 
		"UN_CM", 
		"TIKZGRAPH", 
		"ID", 
		"FLOAT", 
		"INT", 
		"ARROW", 
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
		"'-'", 
		"'to'"
    };

    public const int TIKZGRAPH = 38;
    public const int EXPONENT = 43;
    public const int RBR = 14;
    public const int EDGE = 9;
    public const int ST_LINEWIDTH = 31;
    public const int ST_DASHSTYLE = 32;
    public const int OCTAL_ESC = 50;
    public const int ST_FILL = 27;
    public const int FLOAT = 40;
    public const int BEGINTP = 5;
    public const int ID = 39;
    public const int EOF = -1;
    public const int LBR = 13;
    public const int AT = 10;
    public const int RBRR = 16;
    public const int ESC_SEQ = 46;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int IN = 34;
    public const int LPAR = 11;
    public const int T__53 = 53;
    public const int EVERYLOOP = 24;
    public const int ENDTP = 6;
    public const int T__54 = 54;
    public const int LOOP = 33;
    public const int ST_OUTERSEP = 26;
    public const int COMMENT = 44;
    public const int DEFINECOLOR = 4;
    public const int ST_INNERSEP = 25;
    public const int NODE = 7;
    public const int UN_PTS = 36;
    public const int UNICODE_ESC = 49;
    public const int STYLESEP = 22;
    public const int HEX_DIGIT = 48;
    public const int INT = 41;
    public const int LBRR = 15;
    public const int UN_CM = 37;
    public const int COLON = 21;
    public const int ST_DRAW = 28;
    public const int SCALE = 18;
    public const int WS = 45;
    public const int LABEL = 23;
    public const int ST_MINSIZE = 30;
    public const int OUT = 35;
    public const int KOMMA = 17;
    public const int ST_SHAPE = 29;
    public const int EQU = 19;
    public const int ARROW = 42;
    public const int RPAR = 12;
    public const int SEMIC = 20;
    public const int STRING = 47;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:67:1: tikzpictopts : ( tikzpictopt ( KOMMA tikzpictopt )* )? ;
    public void tikzpictopts() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:68:2: ( ( tikzpictopt ( KOMMA tikzpictopt )* )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:68:4: ( tikzpictopt ( KOMMA tikzpictopt )* )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:68:4: ( tikzpictopt ( KOMMA tikzpictopt )* )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == SCALE || LA2_0 == EVERYLOOP || LA2_0 == ID) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:68:5: tikzpictopt ( KOMMA tikzpictopt )*
            	        {
            	        	PushFollow(FOLLOW_tikzpictopt_in_tikzpictopts371);
            	        	tikzpictopt();
            	        	state.followingStackPointer--;

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:68:17: ( KOMMA tikzpictopt )*
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
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:68:18: KOMMA tikzpictopt
            	        			    {
            	        			    	Match(input,KOMMA,FOLLOW_KOMMA_in_tikzpictopts374); 
            	        			    	PushFollow(FOLLOW_tikzpictopt_in_tikzpictopts376);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:70:1: tikzpicture : ( colordefs )* BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP ;
    public void tikzpicture() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:71:2: ( ( colordefs )* BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:71:4: ( colordefs )* BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:71:4: ( colordefs )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:71:5: colordefs
            			    {
            			    	PushFollow(FOLLOW_colordefs_in_tikzpicture393);
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

            	Match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture397); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:71:25: ( LBR tikzpictopts RBR )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == LBR) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:71:26: LBR tikzpictopts RBR
            	        {
            	        	Match(input,LBR,FOLLOW_LBR_in_tikzpicture400); 
            	        	PushFollow(FOLLOW_tikzpictopts_in_tikzpicture402);
            	        	tikzpictopts();
            	        	state.followingStackPointer--;

            	        	Match(input,RBR,FOLLOW_RBR_in_tikzpicture404); 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzbody_in_tikzpicture408);
            	tikzbody();
            	state.followingStackPointer--;

            	Match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture410); 
            	 //tres.InferStyleTypes();
            										      tres.CleanUpAfterParsing(); 

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:74:1: colordefs : DEFINECOLOR LBRR ID RBRR LBRR 'rgb' RBRR LBRR tr= FLOAT KOMMA tg= FLOAT KOMMA tb= FLOAT RBRR ;
    public void colordefs() // throws RecognitionException [1]
    {   
        IToken tr = null;
        IToken tg = null;
        IToken tb = null;
        IToken ID1 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:75:2: ( DEFINECOLOR LBRR ID RBRR LBRR 'rgb' RBRR LBRR tr= FLOAT KOMMA tg= FLOAT KOMMA tb= FLOAT RBRR )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:75:4: DEFINECOLOR LBRR ID RBRR LBRR 'rgb' RBRR LBRR tr= FLOAT KOMMA tg= FLOAT KOMMA tb= FLOAT RBRR
            {
            	Match(input,DEFINECOLOR,FOLLOW_DEFINECOLOR_in_colordefs422); 
            	Match(input,LBRR,FOLLOW_LBRR_in_colordefs424); 
            	ID1=(IToken)Match(input,ID,FOLLOW_ID_in_colordefs426); 
            	Match(input,RBRR,FOLLOW_RBRR_in_colordefs428); 
            	Match(input,LBRR,FOLLOW_LBRR_in_colordefs430); 
            	Match(input,51,FOLLOW_51_in_colordefs432); 
            	Match(input,RBRR,FOLLOW_RBRR_in_colordefs434); 
            	Match(input,LBRR,FOLLOW_LBRR_in_colordefs436); 
            	tr=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_colordefs440); 
            	Match(input,KOMMA,FOLLOW_KOMMA_in_colordefs442); 
            	tg=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_colordefs446); 
            	Match(input,KOMMA,FOLLOW_KOMMA_in_colordefs448); 
            	tb=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_colordefs452); 
            	Match(input,RBRR,FOLLOW_RBRR_in_colordefs454); 
            	 
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:80:1: tikzpictopt : ( scaleopt | styledef ) ;
    public void tikzpictopt() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:81:2: ( ( scaleopt | styledef ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:81:4: ( scaleopt | styledef )
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:81:4: ( scaleopt | styledef )
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
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:81:5: scaleopt
            	        {
            	        	PushFollow(FOLLOW_scaleopt_in_tikzpictopt467);
            	        	scaleopt();
            	        	state.followingStackPointer--;


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:81:16: styledef
            	        {
            	        	PushFollow(FOLLOW_styledef_in_tikzpictopt471);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:82:1: scaleopt : SCALE EQU FLOAT ;
    public void scaleopt() // throws RecognitionException [1]
    {   
        IToken FLOAT2 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:83:2: ( SCALE EQU FLOAT )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:83:4: SCALE EQU FLOAT
            {
            	Match(input,SCALE,FOLLOW_SCALE_in_scaleopt481); 
            	Match(input,EQU,FOLLOW_EQU_in_scaleopt483); 
            	FLOAT2=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_scaleopt485); 
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:85:1: styledef : (tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR ) ;
    public void styledef() // throws RecognitionException [1]
    {   
        IToken tid = null;

         DrawObjectStyle dos = new DrawObjectStyle(); 
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:2: ( (tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:4: (tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR )
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:4: (tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:87:5: tid= ( EVERYLOOP | ID ) STYLESEP EQU LBRR styleopts[dos] RBRR
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

            		Match(input,STYLESEP,FOLLOW_STYLESEP_in_styledef514); 
            		Match(input,EQU,FOLLOW_EQU_in_styledef516); 
            		Match(input,LBRR,FOLLOW_LBRR_in_styledef518); 
            		PushFollow(FOLLOW_styleopts_in_styledef520);
            		styleopts(dos);
            		state.followingStackPointer--;

            		Match(input,RBRR,FOLLOW_RBRR_in_styledef523); 

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:89:1: styleopts[DrawObjectStyle dos] : ( styleopt[dos] ( KOMMA styleopt[dos] )* )? ;
    public void styleopts(DrawObjectStyle dos) // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:2: ( ( styleopt[dos] ( KOMMA styleopt[dos] )* )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:4: ( styleopt[dos] ( KOMMA styleopt[dos] )* )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:4: ( styleopt[dos] ( KOMMA styleopt[dos] )* )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( ((LA7_0 >= ST_INNERSEP && LA7_0 <= ST_DASHSTYLE) || LA7_0 == ARROW || (LA7_0 >= 52 && LA7_0 <= 53)) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:5: styleopt[dos] ( KOMMA styleopt[dos] )*
            	        {
            	        	PushFollow(FOLLOW_styleopt_in_styleopts539);
            	        	styleopt(dos);
            	        	state.followingStackPointer--;

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:19: ( KOMMA styleopt[dos] )*
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
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:90:20: KOMMA styleopt[dos]
            	        			    {
            	        			    	Match(input,KOMMA,FOLLOW_KOMMA_in_styleopts543); 
            	        			    	PushFollow(FOLLOW_styleopt_in_styleopts545);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:92:1: tikzbody : ( tikznode | tikzedge )* ;
    public void tikzbody() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:2: ( ( tikznode | tikzedge )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:4: ( tikznode | tikzedge )*
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:4: ( tikznode | tikzedge )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:5: tikznode
            			    {
            			    	PushFollow(FOLLOW_tikznode_in_tikzbody562);
            			    	tikznode();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:93:16: tikzedge
            			    {
            			    	PushFollow(FOLLOW_tikzedge_in_tikzbody566);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:94:1: styleopt[DrawObjectStyle dos] : ( ( ST_INNERSEP EQU INT ( UN_PTS )? ) | ( ST_OUTERSEP EQU INT ( UN_PTS )? ) | ( ST_FILL ( EQU ID )? ) | ( ST_DRAW ( EQU ID )? ) | ST_SHAPE EQU ID | ST_MINSIZE EQU INT ( UN_PTS )? | arrowstyleopt[dos] | ST_LINEWIDTH EQU FLOAT ( UN_PTS )? | ST_DASHSTYLE EQU ID );
    public void styleopt(DrawObjectStyle dos) // throws RecognitionException [1]
    {   
        IToken INT3 = null;
        IToken INT4 = null;
        IToken ID5 = null;
        IToken ID6 = null;
        IToken ID7 = null;
        IToken INT8 = null;
        IToken FLOAT9 = null;
        IToken ID10 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:95:2: ( ( ST_INNERSEP EQU INT ( UN_PTS )? ) | ( ST_OUTERSEP EQU INT ( UN_PTS )? ) | ( ST_FILL ( EQU ID )? ) | ( ST_DRAW ( EQU ID )? ) | ST_SHAPE EQU ID | ST_MINSIZE EQU INT ( UN_PTS )? | arrowstyleopt[dos] | ST_LINEWIDTH EQU FLOAT ( UN_PTS )? | ST_DASHSTYLE EQU ID )
            int alt15 = 9;
            switch ( input.LA(1) ) 
            {
            case ST_INNERSEP:
            	{
                alt15 = 1;
                }
                break;
            case ST_OUTERSEP:
            	{
                alt15 = 2;
                }
                break;
            case ST_FILL:
            	{
                alt15 = 3;
                }
                break;
            case ST_DRAW:
            	{
                alt15 = 4;
                }
                break;
            case ST_SHAPE:
            	{
                alt15 = 5;
                }
                break;
            case ST_MINSIZE:
            	{
                alt15 = 6;
                }
                break;
            case ARROW:
            case 52:
            case 53:
            	{
                alt15 = 7;
                }
                break;
            case ST_LINEWIDTH:
            	{
                alt15 = 8;
                }
                break;
            case ST_DASHSTYLE:
            	{
                alt15 = 9;
                }
                break;
            	default:
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:95:4: ( ST_INNERSEP EQU INT ( UN_PTS )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:95:4: ( ST_INNERSEP EQU INT ( UN_PTS )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:95:5: ST_INNERSEP EQU INT ( UN_PTS )?
                    	{
                    		Match(input,ST_INNERSEP,FOLLOW_ST_INNERSEP_in_styleopt579); 
                    		Match(input,EQU,FOLLOW_EQU_in_styleopt581); 
                    		INT3=(IToken)Match(input,INT,FOLLOW_INT_in_styleopt583); 
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:95:25: ( UN_PTS )?
                    		int alt9 = 2;
                    		int LA9_0 = input.LA(1);

                    		if ( (LA9_0 == UN_PTS) )
                    		{
                    		    alt9 = 1;
                    		}
                    		switch (alt9) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:95:25: UN_PTS
                    		        {
                    		        	Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt585); 

                    		        }
                    		        break;

                    		}


                    	}

                    	 dos.innersep = Int32.Parse(((INT3 != null) ? INT3.Text : null)); dos.type = DOType.V; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:96:4: ( ST_OUTERSEP EQU INT ( UN_PTS )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:96:4: ( ST_OUTERSEP EQU INT ( UN_PTS )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:96:5: ST_OUTERSEP EQU INT ( UN_PTS )?
                    	{
                    		Match(input,ST_OUTERSEP,FOLLOW_ST_OUTERSEP_in_styleopt596); 
                    		Match(input,EQU,FOLLOW_EQU_in_styleopt598); 
                    		INT4=(IToken)Match(input,INT,FOLLOW_INT_in_styleopt600); 
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:96:25: ( UN_PTS )?
                    		int alt10 = 2;
                    		int LA10_0 = input.LA(1);

                    		if ( (LA10_0 == UN_PTS) )
                    		{
                    		    alt10 = 1;
                    		}
                    		switch (alt10) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:96:25: UN_PTS
                    		        {
                    		        	Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt602); 

                    		        }
                    		        break;

                    		}


                    	}

                    	 dos.outersep = Int32.Parse(((INT4 != null) ? INT4.Text : null)); dos.type = DOType.V; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:97:4: ( ST_FILL ( EQU ID )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:97:4: ( ST_FILL ( EQU ID )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:97:5: ST_FILL ( EQU ID )?
                    	{
                    		Match(input,ST_FILL,FOLLOW_ST_FILL_in_styleopt612); 
                    		dos.lfill = true;
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:98:5: ( EQU ID )?
                    		int alt11 = 2;
                    		int LA11_0 = input.LA(1);

                    		if ( (LA11_0 == EQU) )
                    		{
                    		    alt11 = 1;
                    		}
                    		switch (alt11) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:98:6: EQU ID
                    		        {
                    		        	Match(input,EQU,FOLLOW_EQU_in_styleopt621); 
                    		        	ID5=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt623); 
                    		        	dos.fill = DrawObjectStyle.TikzStringToColor(((ID5 != null) ? ID5.Text : null));

                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:99:4: ( ST_DRAW ( EQU ID )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:99:4: ( ST_DRAW ( EQU ID )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:99:5: ST_DRAW ( EQU ID )?
                    	{
                    		Match(input,ST_DRAW,FOLLOW_ST_DRAW_in_styleopt635); 
                    		dos.ldraw = true;
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:100:5: ( EQU ID )?
                    		int alt12 = 2;
                    		int LA12_0 = input.LA(1);

                    		if ( (LA12_0 == EQU) )
                    		{
                    		    alt12 = 1;
                    		}
                    		switch (alt12) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:100:6: EQU ID
                    		        {
                    		        	Match(input,EQU,FOLLOW_EQU_in_styleopt644); 
                    		        	ID6=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt646); 
                    		        	dos.draw = DrawObjectStyle.TikzStringToColor(((ID6 != null) ? ID6.Text : null));

                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 5 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:101:4: ST_SHAPE EQU ID
                    {
                    	Match(input,ST_SHAPE,FOLLOW_ST_SHAPE_in_styleopt656); 
                    	Match(input,EQU,FOLLOW_EQU_in_styleopt658); 
                    	ID7=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt660); 
                    	 dos.shape = (vshape)Enum.Parse(typeof(vshape),((ID7 != null) ? ID7.Text : null)); dos.type = DOType.V; 

                    }
                    break;
                case 6 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:102:4: ST_MINSIZE EQU INT ( UN_PTS )?
                    {
                    	Match(input,ST_MINSIZE,FOLLOW_ST_MINSIZE_in_styleopt667); 
                    	Match(input,EQU,FOLLOW_EQU_in_styleopt669); 
                    	INT8=(IToken)Match(input,INT,FOLLOW_INT_in_styleopt671); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:102:23: ( UN_PTS )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == UN_PTS) )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:102:23: UN_PTS
                    	        {
                    	        	Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt673); 

                    	        }
                    	        break;

                    	}

                    	 dos.minimumsize=Int32.Parse(((INT8 != null) ? INT8.Text : null)); dos.type = DOType.V; 

                    }
                    break;
                case 7 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:103:4: arrowstyleopt[dos]
                    {
                    	PushFollow(FOLLOW_arrowstyleopt_in_styleopt681);
                    	arrowstyleopt(dos);
                    	state.followingStackPointer--;


                    }
                    break;
                case 8 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:104:4: ST_LINEWIDTH EQU FLOAT ( UN_PTS )?
                    {
                    	Match(input,ST_LINEWIDTH,FOLLOW_ST_LINEWIDTH_in_styleopt687); 
                    	Match(input,EQU,FOLLOW_EQU_in_styleopt689); 
                    	FLOAT9=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_styleopt691); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:104:27: ( UN_PTS )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( (LA14_0 == UN_PTS) )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:104:27: UN_PTS
                    	        {
                    	        	Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt693); 

                    	        }
                    	        break;

                    	}

                    	 dos.LineWidth = (float)Double.Parse(((FLOAT9 != null) ? FLOAT9.Text : null)); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:105:4: ST_DASHSTYLE EQU ID
                    {
                    	Match(input,ST_DASHSTYLE,FOLLOW_ST_DASHSTYLE_in_styleopt701); 
                    	Match(input,EQU,FOLLOW_EQU_in_styleopt703); 
                    	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt705); 
                    	 dos.dashstyle = Helper.TikzDashStyleFromString(((ID10 != null) ? ID10.Text : null)); 

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


    // $ANTLR start "arrowstyleopt"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:107:1: arrowstyleopt[DrawObjectStyle dos] : ( '--' | (a1= ARROW )? '-' (a2= ARROW )? );
    public void arrowstyleopt(DrawObjectStyle dos) // throws RecognitionException [1]
    {   
        IToken a1 = null;
        IToken a2 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:108:2: ( '--' | (a1= ARROW )? '-' (a2= ARROW )? )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == 52) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == ARROW || LA18_0 == 53) )
            {
                alt18 = 2;
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:108:4: '--'
                    {
                    	Match(input,52,FOLLOW_52_in_arrowstyleopt719); 
                    	 dos.type = DOType.E; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:5: (a1= ARROW )? '-' (a2= ARROW )?
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:5: (a1= ARROW )?
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( (LA16_0 == ARROW) )
                    	{
                    	    alt16 = 1;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:6: a1= ARROW
                    	        {
                    	        	a1=(IToken)Match(input,ARROW,FOLLOW_ARROW_in_arrowstyleopt730); 

                    	        }
                    	        break;

                    	}

                    	Match(input,53,FOLLOW_53_in_arrowstyleopt734); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:21: (a2= ARROW )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( (LA17_0 == ARROW) )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:109:22: a2= ARROW
                    	        {
                    	        	a2=(IToken)Match(input,ARROW,FOLLOW_ARROW_in_arrowstyleopt739); 

                    	        }
                    	        break;

                    	}

                    	 dos.fromTip = Helper.TikzArrowTipFromString(((a1 != null) ? a1.Text : null));
                    							dos.toTip = Helper.TikzArrowTipFromString(((a2 != null) ? a2.Text : null));
                    							dos.type = DOType.E; 

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
    // $ANTLR end "arrowstyleopt"


    // $ANTLR start "tikznode"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:119:1: tikznode : NODE LPAR ID RPAR ( LBR nodeopts[v] RBR )? AT LPAR tx= number KOMMA ty= number RPAR ( LBR nodeopts[v] RBR )? nodetext[v] SEMIC ;
    public void tikznode() // throws RecognitionException [1]
    {   
        IToken ID11 = null;
        tikzgrammarParser.number_return tx = null;

        tikzgrammarParser.number_return ty = null;


         vertex v = new vertex(); 
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:121:2: ( NODE LPAR ID RPAR ( LBR nodeopts[v] RBR )? AT LPAR tx= number KOMMA ty= number RPAR ( LBR nodeopts[v] RBR )? nodetext[v] SEMIC )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:121:4: NODE LPAR ID RPAR ( LBR nodeopts[v] RBR )? AT LPAR tx= number KOMMA ty= number RPAR ( LBR nodeopts[v] RBR )? nodetext[v] SEMIC
            {
            	Match(input,NODE,FOLLOW_NODE_in_tikznode766); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikznode768); 
            	ID11=(IToken)Match(input,ID,FOLLOW_ID_in_tikznode770); 
            	Match(input,RPAR,FOLLOW_RPAR_in_tikznode772); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:121:22: ( LBR nodeopts[v] RBR )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == LBR) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:121:23: LBR nodeopts[v] RBR
            	        {
            	        	Match(input,LBR,FOLLOW_LBR_in_tikznode775); 
            	        	PushFollow(FOLLOW_nodeopts_in_tikznode777);
            	        	nodeopts(v);
            	        	state.followingStackPointer--;

            	        	Match(input,RBR,FOLLOW_RBR_in_tikznode780); 

            	        }
            	        break;

            	}

            	Match(input,AT,FOLLOW_AT_in_tikznode784); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikznode786); 
            	PushFollow(FOLLOW_number_in_tikznode790);
            	tx = number();
            	state.followingStackPointer--;

            	Match(input,KOMMA,FOLLOW_KOMMA_in_tikznode792); 
            	PushFollow(FOLLOW_number_in_tikznode796);
            	ty = number();
            	state.followingStackPointer--;

            	Match(input,RPAR,FOLLOW_RPAR_in_tikznode798); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:121:84: ( LBR nodeopts[v] RBR )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == LBR) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:121:85: LBR nodeopts[v] RBR
            	        {
            	        	Match(input,LBR,FOLLOW_LBR_in_tikznode801); 
            	        	PushFollow(FOLLOW_nodeopts_in_tikznode803);
            	        	nodeopts(v);
            	        	state.followingStackPointer--;

            	        	Match(input,RBR,FOLLOW_RBR_in_tikznode806); 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_nodetext_in_tikznode810);
            	nodetext(v);
            	state.followingStackPointer--;

            	Match(input,SEMIC,FOLLOW_SEMIC_in_tikznode813); 
            	 v.name = ((ID11 != null) ? ID11.Text : null);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:125:1: nodetext[vertex v] : LBRR ( ID )? RBRR ;
    public void nodetext(vertex v) // throws RecognitionException [1]
    {   
        IToken ID12 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:126:2: ( LBRR ( ID )? RBRR )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:126:4: LBRR ( ID )? RBRR
            {
            	Match(input,LBRR,FOLLOW_LBRR_in_nodetext827); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:126:9: ( ID )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == ID) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:126:10: ID
            	        {
            	        	ID12=(IToken)Match(input,ID,FOLLOW_ID_in_nodetext830); 
            	        	 v.text = ((ID12 != null) ? ID12.Text : null); 

            	        }
            	        break;

            	}

            	Match(input,RBRR,FOLLOW_RBRR_in_nodetext837); 

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:129:1: number : ( FLOAT | INT ) ;
    public tikzgrammarParser.number_return number() // throws RecognitionException [1]
    {   
        tikzgrammarParser.number_return retval = new tikzgrammarParser.number_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:129:9: ( ( FLOAT | INT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:129:11: ( FLOAT | INT )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:130:1: nodeopts[vertex v] : nodeopt[v] ( KOMMA nodeopt[v] )* ;
    public void nodeopts(vertex v) // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:131:2: ( nodeopt[v] ( KOMMA nodeopt[v] )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:131:4: nodeopt[v] ( KOMMA nodeopt[v] )*
            {
            	PushFollow(FOLLOW_nodeopt_in_nodeopts863);
            	nodeopt(v);
            	state.followingStackPointer--;

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:131:15: ( KOMMA nodeopt[v] )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:131:16: KOMMA nodeopt[v]
            			    {
            			    	Match(input,KOMMA,FOLLOW_KOMMA_in_nodeopts867); 
            			    	PushFollow(FOLLOW_nodeopt_in_nodeopts869);
            			    	nodeopt(v);
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
    // $ANTLR end "nodeopts"


    // $ANTLR start "nodeopt"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:133:1: nodeopt[vertex v] : ( ID | LABEL EQU ( INT COLON )? ID );
    public void nodeopt(vertex v) // throws RecognitionException [1]
    {   
        IToken ID13 = null;
        IToken INT14 = null;
        IToken ID15 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:134:2: ( ID | LABEL EQU ( INT COLON )? ID )
            int alt24 = 2;
            int LA24_0 = input.LA(1);

            if ( (LA24_0 == ID) )
            {
                alt24 = 1;
            }
            else if ( (LA24_0 == LABEL) )
            {
                alt24 = 2;
            }
            else 
            {
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:134:4: ID
                    {
                    	ID13=(IToken)Match(input,ID,FOLLOW_ID_in_nodeopt884); 
                    	 v.style = tres.styles[((ID13 != null) ? ID13.Text : null)];	 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:135:4: LABEL EQU ( INT COLON )? ID
                    {
                    	Match(input,LABEL,FOLLOW_LABEL_in_nodeopt892); 
                    	Match(input,EQU,FOLLOW_EQU_in_nodeopt894); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:135:14: ( INT COLON )?
                    	int alt23 = 2;
                    	int LA23_0 = input.LA(1);

                    	if ( (LA23_0 == INT) )
                    	{
                    	    alt23 = 1;
                    	}
                    	switch (alt23) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:135:15: INT COLON
                    	        {
                    	        	INT14=(IToken)Match(input,INT,FOLLOW_INT_in_nodeopt897); 
                    	        	Match(input,COLON,FOLLOW_COLON_in_nodeopt899); 
                    	        	v.labelangle=Int32.Parse(((INT14 != null) ? INT14.Text : null));

                    	        }
                    	        break;

                    	}

                    	ID15=(IToken)Match(input,ID,FOLLOW_ID_in_nodeopt905); 
                    	v.label=((ID15 != null) ? ID15.Text : null); 

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:138:1: tikzedge : DRAW LBR edgeopts[ed] RBR LPAR vf= ID RPAR ( '--' | 'to' ) LPAR (vt= ID )? RPAR SEMIC ;
    public void tikzedge() // throws RecognitionException [1]
    {   
        IToken vf = null;
        IToken vt = null;

         edge ed = new edge(); 
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:140:2: ( DRAW LBR edgeopts[ed] RBR LPAR vf= ID RPAR ( '--' | 'to' ) LPAR (vt= ID )? RPAR SEMIC )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:140:4: DRAW LBR edgeopts[ed] RBR LPAR vf= ID RPAR ( '--' | 'to' ) LPAR (vt= ID )? RPAR SEMIC
            {
            	Match(input,DRAW,FOLLOW_DRAW_in_tikzedge927); 
            	Match(input,LBR,FOLLOW_LBR_in_tikzedge929); 
            	PushFollow(FOLLOW_edgeopts_in_tikzedge931);
            	edgeopts(ed);
            	state.followingStackPointer--;

            	Match(input,RBR,FOLLOW_RBR_in_tikzedge934); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikzedge936); 
            	vf=(IToken)Match(input,ID,FOLLOW_ID_in_tikzedge940); 
            	Match(input,RPAR,FOLLOW_RPAR_in_tikzedge942); 
            	if ( input.LA(1) == 52 || input.LA(1) == 54 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	Match(input,LPAR,FOLLOW_LPAR_in_tikzedge950); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:140:63: (vt= ID )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == ID) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:140:64: vt= ID
            	        {
            	        	vt=(IToken)Match(input,ID,FOLLOW_ID_in_tikzedge955); 

            	        }
            	        break;

            	}

            	Match(input,RPAR,FOLLOW_RPAR_in_tikzedge959); 
            	Match(input,SEMIC,FOLLOW_SEMIC_in_tikzedge961); 
            	 
            									  ed.from = tres.vfromname(((vf != null) ? vf.Text : null));
            									  ed.to = tres.vfromname(((vt != null) ? vt.Text : null));
            									  if (ed.to==null) 
            									  	ed.to=ed.from;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:147:1: edgeopts[edge ed] : edgeopt[ed] ( KOMMA edgeopt[ed] )* ;
    public void edgeopts(edge ed) // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:148:2: ( edgeopt[ed] ( KOMMA edgeopt[ed] )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:148:4: edgeopt[ed] ( KOMMA edgeopt[ed] )*
            {
            	PushFollow(FOLLOW_edgeopt_in_edgeopts974);
            	edgeopt(ed);
            	state.followingStackPointer--;

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:148:16: ( KOMMA edgeopt[ed] )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( (LA26_0 == KOMMA) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:148:17: KOMMA edgeopt[ed]
            			    {
            			    	Match(input,KOMMA,FOLLOW_KOMMA_in_edgeopts978); 
            			    	PushFollow(FOLLOW_edgeopt_in_edgeopts980);
            			    	edgeopt(ed);
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements


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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:150:1: edgeopt[edge ed] : ( ID | LOOP | IN EQU INT | OUT EQU INT );
    public void edgeopt(edge ed) // throws RecognitionException [1]
    {   
        IToken ID16 = null;
        IToken INT17 = null;
        IToken INT18 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:151:2: ( ID | LOOP | IN EQU INT | OUT EQU INT )
            int alt27 = 4;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt27 = 1;
                }
                break;
            case LOOP:
            	{
                alt27 = 2;
                }
                break;
            case IN:
            	{
                alt27 = 3;
                }
                break;
            case OUT:
            	{
                alt27 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d27s0 =
            	        new NoViableAltException("", 27, 0, input);

            	    throw nvae_d27s0;
            }

            switch (alt27) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:151:4: ID
                    {
                    	ID16=(IToken)Match(input,ID,FOLLOW_ID_in_edgeopt995); 
                    	 ed.style = tres.styles[((ID16 != null) ? ID16.Text : null)]; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:152:4: LOOP
                    {
                    	Match(input,LOOP,FOLLOW_LOOP_in_edgeopt1003); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:153:4: IN EQU INT
                    {
                    	Match(input,IN,FOLLOW_IN_in_edgeopt1009); 
                    	Match(input,EQU,FOLLOW_EQU_in_edgeopt1011); 
                    	INT17=(IToken)Match(input,INT,FOLLOW_INT_in_edgeopt1013); 
                    	 ed.inangle=Int32.Parse(((INT17 != null) ? INT17.Text : null)); ed.useinoutangle=true; 

                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\graph2tikz\\GraphToTIKZ\\tikzgrammar.g:154:4: OUT EQU INT
                    {
                    	Match(input,OUT,FOLLOW_OUT_in_edgeopt1020); 
                    	Match(input,EQU,FOLLOW_EQU_in_edgeopt1022); 
                    	INT18=(IToken)Match(input,INT,FOLLOW_INT_in_edgeopt1024); 
                    	 ed.outangle=Int32.Parse(((INT18 != null) ? INT18.Text : null)); ed.useinoutangle=true; 

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

 

    public static readonly BitSet FOLLOW_tikzpictopt_in_tikzpictopts371 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikzpictopts374 = new BitSet(new ulong[]{0x0000008001040000UL});
    public static readonly BitSet FOLLOW_tikzpictopt_in_tikzpictopts376 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_colordefs_in_tikzpicture393 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_BEGINTP_in_tikzpicture397 = new BitSet(new ulong[]{0x00000000000021C0UL});
    public static readonly BitSet FOLLOW_LBR_in_tikzpicture400 = new BitSet(new ulong[]{0x0000008001044000UL});
    public static readonly BitSet FOLLOW_tikzpictopts_in_tikzpicture402 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikzpicture404 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture408 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ENDTP_in_tikzpicture410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DEFINECOLOR_in_colordefs422 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LBRR_in_colordefs424 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_colordefs426 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_colordefs428 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LBRR_in_colordefs430 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_colordefs432 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_colordefs434 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LBRR_in_colordefs436 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_colordefs440 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_colordefs442 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_colordefs446 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_colordefs448 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_colordefs452 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_colordefs454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scaleopt_in_tikzpictopt467 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_styledef_in_tikzpictopt471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SCALE_in_scaleopt481 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_scaleopt483 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_scaleopt485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_styledef506 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_STYLESEP_in_styledef514 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styledef516 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LBRR_in_styledef518 = new BitSet(new ulong[]{0x00300401FE010000UL});
    public static readonly BitSet FOLLOW_styleopts_in_styledef520 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_styledef523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_styleopt_in_styleopts539 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_styleopts543 = new BitSet(new ulong[]{0x00300401FE000000UL});
    public static readonly BitSet FOLLOW_styleopt_in_styleopts545 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikzbody562 = new BitSet(new ulong[]{0x0000000000000182UL});
    public static readonly BitSet FOLLOW_tikzedge_in_tikzbody566 = new BitSet(new ulong[]{0x0000000000000182UL});
    public static readonly BitSet FOLLOW_ST_INNERSEP_in_styleopt579 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt581 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_INT_in_styleopt583 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt585 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_OUTERSEP_in_styleopt596 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt598 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_INT_in_styleopt600 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_FILL_in_styleopt612 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt621 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_DRAW_in_styleopt635 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt644 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt646 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_SHAPE_in_styleopt656 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt658 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_MINSIZE_in_styleopt667 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt669 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_INT_in_styleopt671 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrowstyleopt_in_styleopt681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_LINEWIDTH_in_styleopt687 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt689 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_styleopt691 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_DASHSTYLE_in_styleopt701 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt703 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_arrowstyleopt719 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARROW_in_arrowstyleopt730 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_arrowstyleopt734 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_ARROW_in_arrowstyleopt739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_tikznode766 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikznode768 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_tikznode770 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikznode772 = new BitSet(new ulong[]{0x0000000000002400UL});
    public static readonly BitSet FOLLOW_LBR_in_tikznode775 = new BitSet(new ulong[]{0x0000008000800000UL});
    public static readonly BitSet FOLLOW_nodeopts_in_tikznode777 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikznode780 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_AT_in_tikznode784 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikznode786 = new BitSet(new ulong[]{0x0000030000000000UL});
    public static readonly BitSet FOLLOW_number_in_tikznode790 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikznode792 = new BitSet(new ulong[]{0x0000030000000000UL});
    public static readonly BitSet FOLLOW_number_in_tikznode796 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikznode798 = new BitSet(new ulong[]{0x000000000000A000UL});
    public static readonly BitSet FOLLOW_LBR_in_tikznode801 = new BitSet(new ulong[]{0x0000008000800000UL});
    public static readonly BitSet FOLLOW_nodeopts_in_tikznode803 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikznode806 = new BitSet(new ulong[]{0x000000000000A000UL});
    public static readonly BitSet FOLLOW_nodetext_in_tikznode810 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SEMIC_in_tikznode813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRR_in_nodetext827 = new BitSet(new ulong[]{0x0000008000010000UL});
    public static readonly BitSet FOLLOW_ID_in_nodetext830 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RBRR_in_nodetext837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number848 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodeopt_in_nodeopts863 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_nodeopts867 = new BitSet(new ulong[]{0x0000008000800000UL});
    public static readonly BitSet FOLLOW_nodeopt_in_nodeopts869 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_ID_in_nodeopt884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LABEL_in_nodeopt892 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_nodeopt894 = new BitSet(new ulong[]{0x0000028000000000UL});
    public static readonly BitSet FOLLOW_INT_in_nodeopt897 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_COLON_in_nodeopt899 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodeopt905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DRAW_in_tikzedge927 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LBR_in_tikzedge929 = new BitSet(new ulong[]{0x0000008E00000000UL});
    public static readonly BitSet FOLLOW_edgeopts_in_tikzedge931 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikzedge934 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikzedge936 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_tikzedge940 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikzedge942 = new BitSet(new ulong[]{0x0050000000000000UL});
    public static readonly BitSet FOLLOW_set_in_tikzedge944 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikzedge950 = new BitSet(new ulong[]{0x0000008000001000UL});
    public static readonly BitSet FOLLOW_ID_in_tikzedge955 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikzedge959 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SEMIC_in_tikzedge961 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeopt_in_edgeopts974 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_edgeopts978 = new BitSet(new ulong[]{0x0000008E00000000UL});
    public static readonly BitSet FOLLOW_edgeopt_in_edgeopts980 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_ID_in_edgeopt995 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOOP_in_edgeopt1003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IN_in_edgeopt1009 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_edgeopt1011 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_INT_in_edgeopt1013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OUT_in_edgeopt1020 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EQU_in_edgeopt1022 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_INT_in_edgeopt1024 = new BitSet(new ulong[]{0x0000000000000002UL});

}
