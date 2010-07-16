// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g 2010-06-17 19:46:05

 using GraphToTIKZ; 

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
		"ST_INNERSEP", 
		"ST_OUTERSEP", 
		"ST_FILL", 
		"ST_DRAW", 
		"ST_SHAPE", 
		"UN_PTS", 
		"UN_CM", 
		"UN_IN", 
		"TIKZGRAPH", 
		"FLOAT", 
		"ID", 
		"INT", 
		"EXPONENT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"STRING", 
		"HEX_DIGIT", 
		"UNICODE_ESC", 
		"OCTAL_ESC", 
		"'--'"
    };

    public const int TIKZGRAPH = 31;
    public const int EXPONENT = 35;
    public const int RBR = 13;
    public const int EDGE = 8;
    public const int OCTAL_ESC = 42;
    public const int ST_FILL = 25;
    public const int BEGINTP = 4;
    public const int FLOAT = 32;
    public const int ID = 33;
    public const int EOF = -1;
    public const int LBR = 12;
    public const int AT = 9;
    public const int RBRR = 15;
    public const int ESC_SEQ = 38;
    public const int LPAR = 10;
    public const int ENDTP = 5;
    public const int ST_OUTERSEP = 24;
    public const int COMMENT = 36;
    public const int ST_INNERSEP = 23;
    public const int T__43 = 43;
    public const int NODE = 6;
    public const int UN_PTS = 28;
    public const int UN_IN = 30;
    public const int UNICODE_ESC = 41;
    public const int STYLESEP = 21;
    public const int HEX_DIGIT = 40;
    public const int LBRR = 14;
    public const int INT = 34;
    public const int UN_CM = 29;
    public const int COLON = 20;
    public const int ST_DRAW = 26;
    public const int SCALE = 17;
    public const int WS = 37;
    public const int LABEL = 22;
    public const int KOMMA = 16;
    public const int ST_SHAPE = 27;
    public const int EQU = 18;
    public const int RPAR = 11;
    public const int SEMIC = 19;
    public const int DRAW = 7;
    public const int STRING = 39;

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
		get { return "C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g"; }
    }

     public TikzGraph tres = new TikzGraph(); 


    // $ANTLR start "tikzpictopts"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:52:1: tikzpictopts : ( tikzpictopt ( KOMMA tikzpictopt )* )? ;
    public void tikzpictopts() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:53:2: ( ( tikzpictopt ( KOMMA tikzpictopt )* )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:53:4: ( tikzpictopt ( KOMMA tikzpictopt )* )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:53:4: ( tikzpictopt ( KOMMA tikzpictopt )* )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == SCALE || LA2_0 == ID) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:53:5: tikzpictopt ( KOMMA tikzpictopt )*
            	        {
            	        	PushFollow(FOLLOW_tikzpictopt_in_tikzpictopts308);
            	        	tikzpictopt();
            	        	state.followingStackPointer--;

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:53:17: ( KOMMA tikzpictopt )*
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
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:53:18: KOMMA tikzpictopt
            	        			    {
            	        			    	Match(input,KOMMA,FOLLOW_KOMMA_in_tikzpictopts311); 
            	        			    	PushFollow(FOLLOW_tikzpictopt_in_tikzpictopts313);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:55:1: tikzpicture : BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP ;
    public void tikzpicture() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:56:2: ( BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:56:4: BEGINTP ( LBR tikzpictopts RBR )? tikzbody ENDTP
            {
            	Match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture329); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:56:12: ( LBR tikzpictopts RBR )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == LBR) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:56:13: LBR tikzpictopts RBR
            	        {
            	        	Match(input,LBR,FOLLOW_LBR_in_tikzpicture332); 
            	        	PushFollow(FOLLOW_tikzpictopts_in_tikzpicture334);
            	        	tikzpictopts();
            	        	state.followingStackPointer--;

            	        	Match(input,RBR,FOLLOW_RBR_in_tikzpicture336); 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzbody_in_tikzpicture340);
            	tikzbody();
            	state.followingStackPointer--;

            	Match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture342); 

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


    // $ANTLR start "tikzpictopt"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:58:1: tikzpictopt : ( scaleopt | styledef ) ;
    public void tikzpictopt() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:59:2: ( ( scaleopt | styledef ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:59:4: ( scaleopt | styledef )
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:59:4: ( scaleopt | styledef )
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == SCALE) )
            	{
            	    alt4 = 1;
            	}
            	else if ( (LA4_0 == ID) )
            	{
            	    alt4 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:59:5: scaleopt
            	        {
            	        	PushFollow(FOLLOW_scaleopt_in_tikzpictopt353);
            	        	scaleopt();
            	        	state.followingStackPointer--;


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:59:16: styledef
            	        {
            	        	PushFollow(FOLLOW_styledef_in_tikzpictopt357);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:60:1: scaleopt : SCALE EQU FLOAT ;
    public void scaleopt() // throws RecognitionException [1]
    {   
        IToken FLOAT1 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:61:2: ( SCALE EQU FLOAT )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:61:4: SCALE EQU FLOAT
            {
            	Match(input,SCALE,FOLLOW_SCALE_in_scaleopt367); 
            	Match(input,EQU,FOLLOW_EQU_in_scaleopt369); 
            	FLOAT1=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_scaleopt371); 
            	tres.scale = Double.Parse(((FLOAT1 != null) ? FLOAT1.Text : null));

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:63:1: styledef : ( ID STYLESEP EQU LBRR styleopts[dos] RBRR ) ;
    public void styledef() // throws RecognitionException [1]
    {   
        IToken ID2 = null;

         DrawObjectStyle dos = new DrawObjectStyle(); 
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:65:2: ( ( ID STYLESEP EQU LBRR styleopts[dos] RBRR ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:65:4: ( ID STYLESEP EQU LBRR styleopts[dos] RBRR )
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:65:4: ( ID STYLESEP EQU LBRR styleopts[dos] RBRR )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:65:5: ID STYLESEP EQU LBRR styleopts[dos] RBRR
            	{
            		ID2=(IToken)Match(input,ID,FOLLOW_ID_in_styledef390); 
            		Match(input,STYLESEP,FOLLOW_STYLESEP_in_styledef392); 
            		Match(input,EQU,FOLLOW_EQU_in_styledef394); 
            		Match(input,LBRR,FOLLOW_LBRR_in_styledef396); 
            		PushFollow(FOLLOW_styleopts_in_styledef398);
            		styleopts(dos);
            		state.followingStackPointer--;

            		Match(input,RBRR,FOLLOW_RBRR_in_styledef401); 

            	}

            	 dos.name=((ID2 != null) ? ID2.Text : null); tres.styles.Add(dos.name, dos); 

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:67:1: styleopts[DrawObjectStyle dos] : ( styleopt[dos] ( KOMMA styleopt[dos] )* )? ;
    public void styleopts(DrawObjectStyle dos) // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:68:2: ( ( styleopt[dos] ( KOMMA styleopt[dos] )* )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:68:4: ( styleopt[dos] ( KOMMA styleopt[dos] )* )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:68:4: ( styleopt[dos] ( KOMMA styleopt[dos] )* )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( ((LA6_0 >= ST_INNERSEP && LA6_0 <= ST_SHAPE)) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:68:5: styleopt[dos] ( KOMMA styleopt[dos] )*
            	        {
            	        	PushFollow(FOLLOW_styleopt_in_styleopts417);
            	        	styleopt(dos);
            	        	state.followingStackPointer--;

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:68:19: ( KOMMA styleopt[dos] )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == KOMMA) )
            	        	    {
            	        	        alt5 = 1;
            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:68:20: KOMMA styleopt[dos]
            	        			    {
            	        			    	Match(input,KOMMA,FOLLOW_KOMMA_in_styleopts421); 
            	        			    	PushFollow(FOLLOW_styleopt_in_styleopts423);
            	        			    	styleopt(dos);
            	        			    	state.followingStackPointer--;


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop5;
            	        	    }
            	        	} while (true);

            	        	loop5:
            	        		;	// Stops C# compiler whining that label 'loop5' has no statements


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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:70:1: tikzbody : ( tikznode | tikzedge )* ;
    public void tikzbody() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:71:2: ( ( tikznode | tikzedge )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:71:4: ( tikznode | tikzedge )*
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:71:4: ( tikznode | tikzedge )*
            	do 
            	{
            	    int alt7 = 3;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == NODE) )
            	    {
            	        alt7 = 1;
            	    }
            	    else if ( (LA7_0 == DRAW) )
            	    {
            	        alt7 = 2;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:71:5: tikznode
            			    {
            			    	PushFollow(FOLLOW_tikznode_in_tikzbody440);
            			    	tikznode();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:71:16: tikzedge
            			    {
            			    	PushFollow(FOLLOW_tikzedge_in_tikzbody444);
            			    	tikzedge();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:72:1: styleopt[DrawObjectStyle dos] : ( ( ST_INNERSEP EQU INT UN_PTS ) | ( ST_OUTERSEP EQU INT UN_PTS ) | ( ST_FILL ( EQU ID )? ) | ( ST_DRAW ( EQU ID )? ) | ST_SHAPE EQU ID );
    public void styleopt(DrawObjectStyle dos) // throws RecognitionException [1]
    {   
        IToken INT3 = null;
        IToken INT4 = null;
        IToken ID5 = null;
        IToken ID6 = null;
        IToken ID7 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:73:2: ( ( ST_INNERSEP EQU INT UN_PTS ) | ( ST_OUTERSEP EQU INT UN_PTS ) | ( ST_FILL ( EQU ID )? ) | ( ST_DRAW ( EQU ID )? ) | ST_SHAPE EQU ID )
            int alt10 = 5;
            switch ( input.LA(1) ) 
            {
            case ST_INNERSEP:
            	{
                alt10 = 1;
                }
                break;
            case ST_OUTERSEP:
            	{
                alt10 = 2;
                }
                break;
            case ST_FILL:
            	{
                alt10 = 3;
                }
                break;
            case ST_DRAW:
            	{
                alt10 = 4;
                }
                break;
            case ST_SHAPE:
            	{
                alt10 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("", 10, 0, input);

            	    throw nvae_d10s0;
            }

            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:73:4: ( ST_INNERSEP EQU INT UN_PTS )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:73:4: ( ST_INNERSEP EQU INT UN_PTS )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:73:5: ST_INNERSEP EQU INT UN_PTS
                    	{
                    		Match(input,ST_INNERSEP,FOLLOW_ST_INNERSEP_in_styleopt457); 
                    		Match(input,EQU,FOLLOW_EQU_in_styleopt459); 
                    		INT3=(IToken)Match(input,INT,FOLLOW_INT_in_styleopt461); 
                    		Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt463); 

                    	}

                    	 dos.innersep = Int32.Parse(((INT3 != null) ? INT3.Text : null)); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:74:4: ( ST_OUTERSEP EQU INT UN_PTS )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:74:4: ( ST_OUTERSEP EQU INT UN_PTS )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:74:5: ST_OUTERSEP EQU INT UN_PTS
                    	{
                    		Match(input,ST_OUTERSEP,FOLLOW_ST_OUTERSEP_in_styleopt473); 
                    		Match(input,EQU,FOLLOW_EQU_in_styleopt475); 
                    		INT4=(IToken)Match(input,INT,FOLLOW_INT_in_styleopt477); 
                    		Match(input,UN_PTS,FOLLOW_UN_PTS_in_styleopt479); 

                    	}

                    	 dos.outersep = Int32.Parse(((INT4 != null) ? INT4.Text : null)); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:75:4: ( ST_FILL ( EQU ID )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:75:4: ( ST_FILL ( EQU ID )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:75:5: ST_FILL ( EQU ID )?
                    	{
                    		Match(input,ST_FILL,FOLLOW_ST_FILL_in_styleopt488); 
                    		dos.lfill = true;
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:76:5: ( EQU ID )?
                    		int alt8 = 2;
                    		int LA8_0 = input.LA(1);

                    		if ( (LA8_0 == EQU) )
                    		{
                    		    alt8 = 1;
                    		}
                    		switch (alt8) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:76:6: EQU ID
                    		        {
                    		        	Match(input,EQU,FOLLOW_EQU_in_styleopt497); 
                    		        	ID5=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt499); 
                    		        	dos.fill = DrawObjectStyle.TikzStringToColor(((ID5 != null) ? ID5.Text : null));

                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:77:4: ( ST_DRAW ( EQU ID )? )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:77:4: ( ST_DRAW ( EQU ID )? )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:77:5: ST_DRAW ( EQU ID )?
                    	{
                    		Match(input,ST_DRAW,FOLLOW_ST_DRAW_in_styleopt511); 
                    		dos.ldraw = true;
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:78:5: ( EQU ID )?
                    		int alt9 = 2;
                    		int LA9_0 = input.LA(1);

                    		if ( (LA9_0 == EQU) )
                    		{
                    		    alt9 = 1;
                    		}
                    		switch (alt9) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:78:6: EQU ID
                    		        {
                    		        	Match(input,EQU,FOLLOW_EQU_in_styleopt520); 
                    		        	ID6=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt522); 
                    		        	dos.draw = DrawObjectStyle.TikzStringToColor(((ID6 != null) ? ID6.Text : null));

                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 5 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:79:4: ST_SHAPE EQU ID
                    {
                    	Match(input,ST_SHAPE,FOLLOW_ST_SHAPE_in_styleopt532); 
                    	Match(input,EQU,FOLLOW_EQU_in_styleopt534); 
                    	ID7=(IToken)Match(input,ID,FOLLOW_ID_in_styleopt536); 
                    	 dos.shape = (vshape)Enum.Parse(typeof(vshape),((ID7 != null) ? ID7.Text : null)); 

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:87:1: tikznode : NODE LPAR ID RPAR ( LBR nodeopts[v] RBR ) AT LPAR tx= number KOMMA ty= number RPAR nodetext SEMIC ;
    public void tikznode() // throws RecognitionException [1]
    {   
        IToken ID8 = null;
        tikzgrammarParser.number_return tx = null;

        tikzgrammarParser.number_return ty = null;

        tikzgrammarParser.nodetext_return nodetext9 = null;


         vertex v = new vertex(); v.id = tres.idcnt++; 
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:89:2: ( NODE LPAR ID RPAR ( LBR nodeopts[v] RBR ) AT LPAR tx= number KOMMA ty= number RPAR nodetext SEMIC )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:89:4: NODE LPAR ID RPAR ( LBR nodeopts[v] RBR ) AT LPAR tx= number KOMMA ty= number RPAR nodetext SEMIC
            {
            	Match(input,NODE,FOLLOW_NODE_in_tikznode561); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikznode563); 
            	ID8=(IToken)Match(input,ID,FOLLOW_ID_in_tikznode565); 
            	Match(input,RPAR,FOLLOW_RPAR_in_tikznode567); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:89:22: ( LBR nodeopts[v] RBR )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:89:23: LBR nodeopts[v] RBR
            	{
            		Match(input,LBR,FOLLOW_LBR_in_tikznode570); 
            		PushFollow(FOLLOW_nodeopts_in_tikznode572);
            		nodeopts(v);
            		state.followingStackPointer--;

            		Match(input,RBR,FOLLOW_RBR_in_tikznode575); 

            	}

            	Match(input,AT,FOLLOW_AT_in_tikznode578); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikznode580); 
            	PushFollow(FOLLOW_number_in_tikznode584);
            	tx = number();
            	state.followingStackPointer--;

            	Match(input,KOMMA,FOLLOW_KOMMA_in_tikznode586); 
            	PushFollow(FOLLOW_number_in_tikznode590);
            	ty = number();
            	state.followingStackPointer--;

            	Match(input,RPAR,FOLLOW_RPAR_in_tikznode592); 
            	PushFollow(FOLLOW_nodetext_in_tikznode594);
            	nodetext9 = nodetext();
            	state.followingStackPointer--;

            	Match(input,SEMIC,FOLLOW_SEMIC_in_tikznode596); 
            	 v.name = ((ID8 != null) ? ID8.Text : null);
            						 v.text=((nodetext9 != null) ? input.ToString((IToken)(nodetext9.Start),(IToken)(nodetext9.Stop)) : null); v.x=Double.Parse(((tx != null) ? input.ToString((IToken)(tx.Start),(IToken)(tx.Stop)) : null)); v.y=Double.Parse(((ty != null) ? input.ToString((IToken)(ty.Start),(IToken)(ty.Stop)) : null)); 
            						 tres.objlist.Add(v.id,v);

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

    public class nodetext_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "nodetext"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:93:1: nodetext : LBRR ( ( . )* ) RBRR ;
    public tikzgrammarParser.nodetext_return nodetext() // throws RecognitionException [1]
    {   
        tikzgrammarParser.nodetext_return retval = new tikzgrammarParser.nodetext_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:94:2: ( LBRR ( ( . )* ) RBRR )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:94:4: LBRR ( ( . )* ) RBRR
            {
            	Match(input,LBRR,FOLLOW_LBRR_in_nodetext609); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:94:9: ( ( . )* )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:94:10: ( . )*
            	{
            		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:94:10: ( . )*
            		do 
            		{
            		    int alt11 = 2;
            		    int LA11_0 = input.LA(1);

            		    if ( (LA11_0 == RBRR) )
            		    {
            		        alt11 = 2;
            		    }
            		    else if ( ((LA11_0 >= BEGINTP && LA11_0 <= LBRR) || (LA11_0 >= KOMMA && LA11_0 <= 43)) )
            		    {
            		        alt11 = 1;
            		    }


            		    switch (alt11) 
            			{
            				case 1 :
            				    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:94:10: .
            				    {
            				    	MatchAny(input); 

            				    }
            				    break;

            				default:
            				    goto loop11;
            		    }
            		} while (true);

            		loop11:
            			;	// Stops C# compiler whining that label 'loop11' has no statements


            	}

            	Match(input,RBRR,FOLLOW_RBRR_in_nodetext616); 

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
    // $ANTLR end "nodetext"

    public class number_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "number"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:97:1: number : ( FLOAT | INT ) ;
    public tikzgrammarParser.number_return number() // throws RecognitionException [1]
    {   
        tikzgrammarParser.number_return retval = new tikzgrammarParser.number_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:97:9: ( ( FLOAT | INT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:97:11: ( FLOAT | INT )
            {
            	if ( input.LA(1) == FLOAT || input.LA(1) == INT ) 
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:98:1: nodeopts[vertex v] : nodeopt[v] ( KOMMA nodeopt[v] )* ;
    public void nodeopts(vertex v) // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:99:2: ( nodeopt[v] ( KOMMA nodeopt[v] )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:99:4: nodeopt[v] ( KOMMA nodeopt[v] )*
            {
            	PushFollow(FOLLOW_nodeopt_in_nodeopts643);
            	nodeopt(v);
            	state.followingStackPointer--;

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:99:15: ( KOMMA nodeopt[v] )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == KOMMA) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:99:16: KOMMA nodeopt[v]
            			    {
            			    	Match(input,KOMMA,FOLLOW_KOMMA_in_nodeopts647); 
            			    	PushFollow(FOLLOW_nodeopt_in_nodeopts649);
            			    	nodeopt(v);
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:101:1: nodeopt[vertex v] : ( ID | LABEL EQU ( INT COLON )? ID );
    public void nodeopt(vertex v) // throws RecognitionException [1]
    {   
        IToken ID10 = null;
        IToken INT11 = null;
        IToken ID12 = null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:102:2: ( ID | LABEL EQU ( INT COLON )? ID )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == ID) )
            {
                alt14 = 1;
            }
            else if ( (LA14_0 == LABEL) )
            {
                alt14 = 2;
            }
            else 
            {
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("", 14, 0, input);

                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:102:4: ID
                    {
                    	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_nodeopt664); 
                    	 v.style = tres.styles[((ID10 != null) ? ID10.Text : null)];	 

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:103:4: LABEL EQU ( INT COLON )? ID
                    {
                    	Match(input,LABEL,FOLLOW_LABEL_in_nodeopt672); 
                    	Match(input,EQU,FOLLOW_EQU_in_nodeopt674); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:103:14: ( INT COLON )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == INT) )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:103:15: INT COLON
                    	        {
                    	        	INT11=(IToken)Match(input,INT,FOLLOW_INT_in_nodeopt677); 
                    	        	Match(input,COLON,FOLLOW_COLON_in_nodeopt679); 
                    	        	v.labelangle=Int32.Parse(((INT11 != null) ? INT11.Text : null));

                    	        }
                    	        break;

                    	}

                    	ID12=(IToken)Match(input,ID,FOLLOW_ID_in_nodeopt685); 
                    	v.label=((ID12 != null) ? ID12.Text : null); 

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:106:1: tikzedge : DRAW LPAR vf= ID RPAR '--' LPAR vt= ID RPAR SEMIC ;
    public void tikzedge() // throws RecognitionException [1]
    {   
        IToken vf = null;
        IToken vt = null;

         edge ed = new edge(); ed.id = tres.idcnt++;
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:108:2: ( DRAW LPAR vf= ID RPAR '--' LPAR vt= ID RPAR SEMIC )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\GraphToTIKZ\\GraphToTIKZ\\tikzgrammar.g:108:4: DRAW LPAR vf= ID RPAR '--' LPAR vt= ID RPAR SEMIC
            {
            	Match(input,DRAW,FOLLOW_DRAW_in_tikzedge707); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikzedge709); 
            	vf=(IToken)Match(input,ID,FOLLOW_ID_in_tikzedge713); 
            	Match(input,RPAR,FOLLOW_RPAR_in_tikzedge715); 
            	Match(input,43,FOLLOW_43_in_tikzedge717); 
            	Match(input,LPAR,FOLLOW_LPAR_in_tikzedge719); 
            	vt=(IToken)Match(input,ID,FOLLOW_ID_in_tikzedge723); 
            	Match(input,RPAR,FOLLOW_RPAR_in_tikzedge725); 
            	Match(input,SEMIC,FOLLOW_SEMIC_in_tikzedge727); 
            	 ed.from = tres.vfromname(((vf != null) ? vf.Text : null));
            									  ed.to = tres.vfromname(((vt != null) ? vt.Text : null)); 
            									  tres.objlist.Add(ed.id,ed); 

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

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_tikzpictopt_in_tikzpictopts308 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikzpictopts311 = new BitSet(new ulong[]{0x0000000200020000UL});
    public static readonly BitSet FOLLOW_tikzpictopt_in_tikzpictopts313 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_BEGINTP_in_tikzpicture329 = new BitSet(new ulong[]{0x00000000000010E0UL});
    public static readonly BitSet FOLLOW_LBR_in_tikzpicture332 = new BitSet(new ulong[]{0x0000000200022000UL});
    public static readonly BitSet FOLLOW_tikzpictopts_in_tikzpicture334 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikzpicture336 = new BitSet(new ulong[]{0x00000000000000E0UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture340 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_ENDTP_in_tikzpicture342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scaleopt_in_tikzpictopt353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_styledef_in_tikzpictopt357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SCALE_in_scaleopt367 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_EQU_in_scaleopt369 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_FLOAT_in_scaleopt371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_styledef390 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_STYLESEP_in_styledef392 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_EQU_in_styledef394 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LBRR_in_styledef396 = new BitSet(new ulong[]{0x000000000F808000UL});
    public static readonly BitSet FOLLOW_styleopts_in_styledef398 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RBRR_in_styledef401 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_styleopt_in_styleopts417 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_styleopts421 = new BitSet(new ulong[]{0x000000000F800000UL});
    public static readonly BitSet FOLLOW_styleopt_in_styleopts423 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikzbody440 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_tikzedge_in_tikzbody444 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_ST_INNERSEP_in_styleopt457 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt459 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_INT_in_styleopt461 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_OUTERSEP_in_styleopt473 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt475 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_INT_in_styleopt477 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_UN_PTS_in_styleopt479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_FILL_in_styleopt488 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt497 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_DRAW_in_styleopt511 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt520 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ST_SHAPE_in_styleopt532 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_EQU_in_styleopt534 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_ID_in_styleopt536 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_tikznode561 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikznode563 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_ID_in_tikznode565 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikznode567 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBR_in_tikznode570 = new BitSet(new ulong[]{0x0000000200400000UL});
    public static readonly BitSet FOLLOW_nodeopts_in_tikznode572 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikznode575 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_AT_in_tikznode578 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikznode580 = new BitSet(new ulong[]{0x0000000500000000UL});
    public static readonly BitSet FOLLOW_number_in_tikznode584 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikznode586 = new BitSet(new ulong[]{0x0000000500000000UL});
    public static readonly BitSet FOLLOW_number_in_tikznode590 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikznode592 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_nodetext_in_tikznode594 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_SEMIC_in_tikznode596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRR_in_nodetext609 = new BitSet(new ulong[]{0x00000FFFFFFFFFF0UL});
    public static readonly BitSet FOLLOW_RBRR_in_nodetext616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodeopt_in_nodeopts643 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_KOMMA_in_nodeopts647 = new BitSet(new ulong[]{0x0000000200400000UL});
    public static readonly BitSet FOLLOW_nodeopt_in_nodeopts649 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_ID_in_nodeopt664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LABEL_in_nodeopt672 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_EQU_in_nodeopt674 = new BitSet(new ulong[]{0x0000000600000000UL});
    public static readonly BitSet FOLLOW_INT_in_nodeopt677 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_COLON_in_nodeopt679 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodeopt685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DRAW_in_tikzedge707 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikzedge709 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_ID_in_tikzedge713 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikzedge715 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzedge717 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LPAR_in_tikzedge719 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_ID_in_tikzedge723 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RPAR_in_tikzedge725 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_SEMIC_in_tikzedge727 = new BitSet(new ulong[]{0x0000000000000002UL});

}
