/* Generated By: CSCC: 4.0 (12/04/2018)  Do not edit this line. SyntaxChecker.cs */
namespace org.mariuszgromada.math.mxparser.syntaxchecker{



using System;
using System.IO;

public class SyntaxChecker : SyntaxCheckerConstants {

        public void checkSyntax() {
                start();
        }

/*
 * Lexer logic - grammar
 */
  public void start() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case DECIMAL:
    case BASE1:
    case BASE2:
    case BASE3:
    case BASE4:
    case BASE5:
    case BASE6:
    case BASE7:
    case BASE8:
    case BASE9:
    case BASE10:
    case BASE11:
    case BASE12:
    case BASE13:
    case BASE14:
    case BASE15:
    case BASE16:
    case BASE17:
    case BASE18:
    case BASE19:
    case BASE20:
    case BASE21:
    case BASE22:
    case BASE23:
    case BASE24:
    case BASE25:
    case BASE26:
    case BASE27:
    case BASE28:
    case BASE29:
    case BASE30:
    case BASE31:
    case BASE32:
    case BASE33:
    case BASE34:
    case BASE35:
    case BASE36:
    case BINARY:
    case OCTAL:
    case HEXADECIMAL:
    case FRACTION:
    case LEFT_PAR:
    case PLUS:
    case MINUS:
    case NOT:
    case BITNOT:
    case IDENTIFIER:
    case LEFT_OR_RIGHT_DER:
    case 124:
    case 125:
    case 126:
      expression();
      jj_consume_token(0);
      break;
    case 0:
      jj_consume_token(0);
      break;
    default:
      jj_la1[0] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();break;
      
    }
  }

  public void expression() {
    binaryExpression();
  }

  public void binaryExpression() {
    unaryRigthExpression();
    while (true) {
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case PLUS:
      case MINUS:
      case MULTIPLY:
      case DIV:
      case POWER:
      case TETRATION:
      case MODULO:
      case EQ:
      case NEQ:
      case LT:
      case LEQ:
      case GT:
      case GEQ:
      case OR:
      case AND:
      case IMP:
      case CIMP:
      case NIMP:
      case CNIMP:
      case NAND:
      case EQV:
      case NOR:
      case BITWISE:
      case XOR:
        ;
        break;
      default:
        jj_la1[1] = jj_gen;
        goto label_1;
        
      }
      binaryOperator();
      unaryRigthExpression();
    }
    label_1: ;
    
  }

  public void unaryRigthExpression() {
    unaryLeftExpression();
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case FACTORIAL:
    case PERCENTAGE:
      unaryRigthOperator();
      break;
    default:
      jj_la1[2] = jj_gen;
      ;break;
      
    }
  }

  public void unaryLeftExpression() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case NOT:
    case BITNOT:
      unaryLeftOperator();
      break;
    default:
      jj_la1[3] = jj_gen;
      ;break;
      
    }
    itemExpression();
  }

  public void binaryOperator() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case PLUS:
      jj_consume_token(PLUS);
      break;
    case MINUS:
      jj_consume_token(MINUS);
      break;
    case MULTIPLY:
      jj_consume_token(MULTIPLY);
      break;
    case DIV:
      jj_consume_token(DIV);
      break;
    case MODULO:
      jj_consume_token(MODULO);
      break;
    case POWER:
      jj_consume_token(POWER);
      break;
    case TETRATION:
      jj_consume_token(TETRATION);
      break;
    case EQ:
      jj_consume_token(EQ);
      break;
    case NEQ:
      jj_consume_token(NEQ);
      break;
    case GT:
      jj_consume_token(GT);
      break;
    case GEQ:
      jj_consume_token(GEQ);
      break;
    case LT:
      jj_consume_token(LT);
      break;
    case LEQ:
      jj_consume_token(LEQ);
      break;
    case OR:
      jj_consume_token(OR);
      break;
    case AND:
      jj_consume_token(AND);
      break;
    case NOR:
      jj_consume_token(NOR);
      break;
    case NAND:
      jj_consume_token(NAND);
      break;
    case XOR:
      jj_consume_token(XOR);
      break;
    case IMP:
      jj_consume_token(IMP);
      break;
    case CIMP:
      jj_consume_token(CIMP);
      break;
    case NIMP:
      jj_consume_token(NIMP);
      break;
    case CNIMP:
      jj_consume_token(CNIMP);
      break;
    case EQV:
      jj_consume_token(EQV);
      break;
    case BITWISE:
      jj_consume_token(BITWISE);
      break;
    default:
      jj_la1[4] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void unaryRigthOperator() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case FACTORIAL:
      jj_consume_token(FACTORIAL);
      break;
    case PERCENTAGE:
      jj_consume_token(PERCENTAGE);
      break;
    default:
      jj_la1[5] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void unaryLeftOperator() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case NOT:
      jj_consume_token(NOT);
      break;
    case BITNOT:
      jj_consume_token(BITNOT);
      break;
    default:
      jj_la1[6] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void itemExpression() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case PLUS:
    case MINUS:
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case PLUS:
        jj_consume_token(PLUS);
        break;
      case MINUS:
        jj_consume_token(MINUS);
        break;
      default:
        jj_la1[7] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
        
      }
      break;
    default:
      jj_la1[8] = jj_gen;
      ;break;
      
    }
    while (true) {
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case DECIMAL:
      case BASE1:
      case BASE2:
      case BASE3:
      case BASE4:
      case BASE5:
      case BASE6:
      case BASE7:
      case BASE8:
      case BASE9:
      case BASE10:
      case BASE11:
      case BASE12:
      case BASE13:
      case BASE14:
      case BASE15:
      case BASE16:
      case BASE17:
      case BASE18:
      case BASE19:
      case BASE20:
      case BASE21:
      case BASE22:
      case BASE23:
      case BASE24:
      case BASE25:
      case BASE26:
      case BASE27:
      case BASE28:
      case BASE29:
      case BASE30:
      case BASE31:
      case BASE32:
      case BASE33:
      case BASE34:
      case BASE35:
      case BASE36:
      case BINARY:
      case OCTAL:
      case HEXADECIMAL:
      case FRACTION:
      case IDENTIFIER:
      case LEFT_OR_RIGHT_DER:
      case 124:
      case 125:
      case 126:
        itemOrFunctionOptionalImpliedMultiplication();
        switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
        case LEFT_PAR:
          bracketedExpressionOptionalImpliedMultiplication();
          break;
        default:
          jj_la1[9] = jj_gen;
          ;break;
          
        }
        switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
        case DECIMAL:
        case BASE1:
        case BASE2:
        case BASE3:
        case BASE4:
        case BASE5:
        case BASE6:
        case BASE7:
        case BASE8:
        case BASE9:
        case BASE10:
        case BASE11:
        case BASE12:
        case BASE13:
        case BASE14:
        case BASE15:
        case BASE16:
        case BASE17:
        case BASE18:
        case BASE19:
        case BASE20:
        case BASE21:
        case BASE22:
        case BASE23:
        case BASE24:
        case BASE25:
        case BASE26:
        case BASE27:
        case BASE28:
        case BASE29:
        case BASE30:
        case BASE31:
        case BASE32:
        case BASE33:
        case BASE34:
        case BASE35:
        case BASE36:
        case BINARY:
        case OCTAL:
        case HEXADECIMAL:
        case FRACTION:
        case IDENTIFIER:
        case LEFT_OR_RIGHT_DER:
        case 124:
        case 125:
        case 126:
          itemOrFunctionOptionalImpliedMultiplication();
          break;
        default:
          jj_la1[10] = jj_gen;
          ;break;
          
        }
        break;
      case LEFT_PAR:
        bracketedExpressionOptionalImpliedMultiplication();
        switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
        case DECIMAL:
        case BASE1:
        case BASE2:
        case BASE3:
        case BASE4:
        case BASE5:
        case BASE6:
        case BASE7:
        case BASE8:
        case BASE9:
        case BASE10:
        case BASE11:
        case BASE12:
        case BASE13:
        case BASE14:
        case BASE15:
        case BASE16:
        case BASE17:
        case BASE18:
        case BASE19:
        case BASE20:
        case BASE21:
        case BASE22:
        case BASE23:
        case BASE24:
        case BASE25:
        case BASE26:
        case BASE27:
        case BASE28:
        case BASE29:
        case BASE30:
        case BASE31:
        case BASE32:
        case BASE33:
        case BASE34:
        case BASE35:
        case BASE36:
        case BINARY:
        case OCTAL:
        case HEXADECIMAL:
        case FRACTION:
        case IDENTIFIER:
        case LEFT_OR_RIGHT_DER:
        case 124:
        case 125:
        case 126:
          itemOrFunctionOptionalImpliedMultiplication();
          break;
        default:
          jj_la1[11] = jj_gen;
          ;break;
          
        }
        break;
      default:
        jj_la1[12] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
        
      }
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case DECIMAL:
      case BASE1:
      case BASE2:
      case BASE3:
      case BASE4:
      case BASE5:
      case BASE6:
      case BASE7:
      case BASE8:
      case BASE9:
      case BASE10:
      case BASE11:
      case BASE12:
      case BASE13:
      case BASE14:
      case BASE15:
      case BASE16:
      case BASE17:
      case BASE18:
      case BASE19:
      case BASE20:
      case BASE21:
      case BASE22:
      case BASE23:
      case BASE24:
      case BASE25:
      case BASE26:
      case BASE27:
      case BASE28:
      case BASE29:
      case BASE30:
      case BASE31:
      case BASE32:
      case BASE33:
      case BASE34:
      case BASE35:
      case BASE36:
      case BINARY:
      case OCTAL:
      case HEXADECIMAL:
      case FRACTION:
      case LEFT_PAR:
      case IDENTIFIER:
      case LEFT_OR_RIGHT_DER:
      case 124:
      case 125:
      case 126:
        ;
        break;
      default:
        jj_la1[13] = jj_gen;
        goto label_2;
        
      }
    }
    label_2: ;
    
  }

  public void bracketedExpressionOptionalImpliedMultiplication() {
    bracketedExpression();
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case LEFT_PAR:
      bracketedExpression();
      break;
    default:
      jj_la1[14] = jj_gen;
      ;break;
      
    }
  }

  public void bracketedExpression() {
    jj_consume_token(LEFT_PAR);
    expression();
    jj_consume_token(RIGHT_PAR);
  }

  public void itemOrFunctionOptionalImpliedMultiplication() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case DECIMAL:
      jj_consume_token(DECIMAL);
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case BASE1:
      case BASE2:
      case BASE3:
      case BASE4:
      case BASE5:
      case BASE6:
      case BASE7:
      case BASE8:
      case BASE9:
      case BASE10:
      case BASE11:
      case BASE12:
      case BASE13:
      case BASE14:
      case BASE15:
      case BASE16:
      case BASE17:
      case BASE18:
      case BASE19:
      case BASE20:
      case BASE21:
      case BASE22:
      case BASE23:
      case BASE24:
      case BASE25:
      case BASE26:
      case BASE27:
      case BASE28:
      case BASE29:
      case BASE30:
      case BASE31:
      case BASE32:
      case BASE33:
      case BASE34:
      case BASE35:
      case BASE36:
      case BINARY:
      case OCTAL:
      case HEXADECIMAL:
      case FRACTION:
      case IDENTIFIER:
      case LEFT_OR_RIGHT_DER:
      case 124:
      case 125:
      case 126:
        itemOrFunctionImpliedMultiplication();
        break;
      default:
        jj_la1[15] = jj_gen;
        ;break;
        
      }
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case DECIMAL:
        jj_consume_token(DECIMAL);
        break;
      default:
        jj_la1[16] = jj_gen;
        ;break;
        
      }
      break;
    case BASE1:
    case BASE2:
    case BASE3:
    case BASE4:
    case BASE5:
    case BASE6:
    case BASE7:
    case BASE8:
    case BASE9:
    case BASE10:
    case BASE11:
    case BASE12:
    case BASE13:
    case BASE14:
    case BASE15:
    case BASE16:
    case BASE17:
    case BASE18:
    case BASE19:
    case BASE20:
    case BASE21:
    case BASE22:
    case BASE23:
    case BASE24:
    case BASE25:
    case BASE26:
    case BASE27:
    case BASE28:
    case BASE29:
    case BASE30:
    case BASE31:
    case BASE32:
    case BASE33:
    case BASE34:
    case BASE35:
    case BASE36:
    case BINARY:
    case OCTAL:
    case HEXADECIMAL:
    case FRACTION:
    case IDENTIFIER:
    case LEFT_OR_RIGHT_DER:
    case 124:
    case 125:
    case 126:
      itemOrFunctionImpliedMultiplication();
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case DECIMAL:
        jj_consume_token(DECIMAL);
        break;
      default:
        jj_la1[17] = jj_gen;
        ;break;
        
      }
      break;
    default:
      jj_la1[18] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void itemOrFunctionImpliedMultiplication() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case IDENTIFIER:
    case LEFT_OR_RIGHT_DER:
    case 124:
    case 125:
    case 126:
      while (true) {
        itemOrFunction();
        switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
        case IDENTIFIER:
        case LEFT_OR_RIGHT_DER:
        case 124:
        case 125:
        case 126:
          ;
          break;
        default:
          jj_la1[19] = jj_gen;
          goto label_3;
          
        }
      }
      label_3: ;
      
      break;
    case BASE1:
    case BASE2:
    case BASE3:
    case BASE4:
    case BASE5:
    case BASE6:
    case BASE7:
    case BASE8:
    case BASE9:
    case BASE10:
    case BASE11:
    case BASE12:
    case BASE13:
    case BASE14:
    case BASE15:
    case BASE16:
    case BASE17:
    case BASE18:
    case BASE19:
    case BASE20:
    case BASE21:
    case BASE22:
    case BASE23:
    case BASE24:
    case BASE25:
    case BASE26:
    case BASE27:
    case BASE28:
    case BASE29:
    case BASE30:
    case BASE31:
    case BASE32:
    case BASE33:
    case BASE34:
    case BASE35:
    case BASE36:
    case BINARY:
    case OCTAL:
    case HEXADECIMAL:
    case FRACTION:
      otherBaseNumber();
      break;
    default:
      jj_la1[20] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void itemOrFunction() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case 124:
    case 125:
    case 126:
      unitOrSpecialConstant();
      break;
    case IDENTIFIER:
    case LEFT_OR_RIGHT_DER:
      itemName();
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case LEFT_PAR:
        argumentList();
        break;
      default:
        jj_la1[21] = jj_gen;
        ;break;
        
      }
      break;
    default:
      jj_la1[22] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void otherBaseNumber() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case HEXADECIMAL:
      jj_consume_token(HEXADECIMAL);
      break;
    case OCTAL:
      jj_consume_token(OCTAL);
      break;
    case BINARY:
      jj_consume_token(BINARY);
      break;
    case BASE1:
      jj_consume_token(BASE1);
      break;
    case BASE2:
      jj_consume_token(BASE2);
      break;
    case BASE3:
      jj_consume_token(BASE3);
      break;
    case BASE4:
      jj_consume_token(BASE4);
      break;
    case BASE5:
      jj_consume_token(BASE5);
      break;
    case BASE6:
      jj_consume_token(BASE6);
      break;
    case BASE7:
      jj_consume_token(BASE7);
      break;
    case BASE8:
      jj_consume_token(BASE8);
      break;
    case BASE9:
      jj_consume_token(BASE9);
      break;
    case BASE10:
      jj_consume_token(BASE10);
      break;
    case BASE11:
      jj_consume_token(BASE11);
      break;
    case BASE12:
      jj_consume_token(BASE12);
      break;
    case BASE13:
      jj_consume_token(BASE13);
      break;
    case BASE14:
      jj_consume_token(BASE14);
      break;
    case BASE15:
      jj_consume_token(BASE15);
      break;
    case BASE16:
      jj_consume_token(BASE16);
      break;
    case BASE17:
      jj_consume_token(BASE17);
      break;
    case BASE18:
      jj_consume_token(BASE18);
      break;
    case BASE19:
      jj_consume_token(BASE19);
      break;
    case BASE20:
      jj_consume_token(BASE20);
      break;
    case BASE21:
      jj_consume_token(BASE21);
      break;
    case BASE22:
      jj_consume_token(BASE22);
      break;
    case BASE23:
      jj_consume_token(BASE23);
      break;
    case BASE24:
      jj_consume_token(BASE24);
      break;
    case BASE25:
      jj_consume_token(BASE25);
      break;
    case BASE26:
      jj_consume_token(BASE26);
      break;
    case BASE27:
      jj_consume_token(BASE27);
      break;
    case BASE28:
      jj_consume_token(BASE28);
      break;
    case BASE29:
      jj_consume_token(BASE29);
      break;
    case BASE30:
      jj_consume_token(BASE30);
      break;
    case BASE31:
      jj_consume_token(BASE31);
      break;
    case BASE32:
      jj_consume_token(BASE32);
      break;
    case BASE33:
      jj_consume_token(BASE33);
      break;
    case BASE34:
      jj_consume_token(BASE34);
      break;
    case BASE35:
      jj_consume_token(BASE35);
      break;
    case BASE36:
      jj_consume_token(BASE36);
      break;
    case FRACTION:
      jj_consume_token(FRACTION);
      break;
    default:
      jj_la1[23] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void itemName() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case IDENTIFIER:
      jj_consume_token(IDENTIFIER);
      break;
    case LEFT_OR_RIGHT_DER:
      jj_consume_token(LEFT_OR_RIGHT_DER);
      break;
    default:
      jj_la1[24] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void unitOrSpecialConstant() {
    switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
    case 124:
      jj_consume_token(124);
      break;
    case 125:
      jj_consume_token(125);
      break;
    case 126:
      jj_consume_token(126);
      while (true) {
        switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
        case OTHER_CHAR:
          jj_consume_token(OTHER_CHAR);
          break;
        case IDENTIFIER:
          jj_consume_token(IDENTIFIER);
          while (true) {
            switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
            case DECIMAL:
            case LEFT_PAR:
            case RIGHT_PAR:
            case COMMA:
            case PLUS:
            case MINUS:
            case MULTIPLY:
            case DIV:
            case POWER:
            case MODULO:
            case LT:
            case GT:
            case OR:
            case AND:
            case NOT:
              ;
              break;
            default:
              jj_la1[25] = jj_gen;
              goto label_5;
              
            }
            switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
            case NOT:
              jj_consume_token(NOT);
              break;
            case MODULO:
              jj_consume_token(MODULO);
              break;
            case POWER:
              jj_consume_token(POWER);
              break;
            case AND:
              jj_consume_token(AND);
              break;
            case MULTIPLY:
              jj_consume_token(MULTIPLY);
              break;
            case DIV:
              jj_consume_token(DIV);
              break;
            case LEFT_PAR:
              jj_consume_token(LEFT_PAR);
              break;
            case RIGHT_PAR:
              jj_consume_token(RIGHT_PAR);
              break;
            case MINUS:
              jj_consume_token(MINUS);
              break;
            case PLUS:
              jj_consume_token(PLUS);
              break;
            case COMMA:
              jj_consume_token(COMMA);
              break;
            case OR:
              jj_consume_token(OR);
              break;
            case GT:
              jj_consume_token(GT);
              break;
            case LT:
              jj_consume_token(LT);
              break;
            case DECIMAL:
              jj_consume_token(DECIMAL);
              break;
            default:
              jj_la1[26] = jj_gen;
              jj_consume_token(-1);
              throw new ParseException();
              
            }
          }
          label_5: ;
          
          break;
        default:
          jj_la1[27] = jj_gen;
          jj_consume_token(-1);
          throw new ParseException();
          
        }
        switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
        case IDENTIFIER:
        case OTHER_CHAR:
          ;
          break;
        default:
          jj_la1[28] = jj_gen;
          goto label_4;
          
        }
      }
      label_4: ;
      
      jj_consume_token(127);
      break;
    default:
      jj_la1[29] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
      
    }
  }

  public void argumentList() {
    jj_consume_token(LEFT_PAR);
    expression();
    while (true) {
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case COMMA:
      case SEMICOLON:
        ;
        break;
      default:
        jj_la1[30] = jj_gen;
        goto label_6;
        
      }
      switch ((jj_ntk==-1)?jj_init_ntk():jj_ntk) {
      case COMMA:
        jj_consume_token(COMMA);
        break;
      case SEMICOLON:
        jj_consume_token(SEMICOLON);
        break;
      default:
        jj_la1[31] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
        
      }
      expression();
    }
    label_6: ;
    
    jj_consume_token(RIGHT_PAR);
  }

  public SyntaxCheckerTokenManager token_source;
  SimpleCharStream jj_input_stream;
  public Token token, jj_nt;
  private long jj_ntk;
  private long jj_gen;
  private long[] jj_la1 = new long[32];
  static private long[] jj_la1_0;
  static private long[] jj_la1_1;
  static private long[] jj_la1_2;
  static private long[] jj_la1_3;
  static private long[] jj_la1_4;
  static SyntaxChecker(){
      jj_la1_init_0();
      jj_la1_init_1();
      jj_la1_init_2();
      jj_la1_init_3();
      jj_la1_init_4();
   }
   private static void jj_la1_init_0() {
      jj_la1_0 = new long[] {0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,};
   }
   private static void jj_la1_init_1() {
      jj_la1_1 = new long[] {0xffff0000,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xffff0000,0xffff0000,0xffff0000,0xffff0000,0x0,0xfffe0000,0x10000,0x10000,0xffff0000,0x0,0xfffe0000,0x0,0x0,0xfffe0000,0x0,0x10000,0x10000,0x0,0x0,0x0,0x0,0x0,};
   }
   private static void jj_la1_init_2() {
      jj_la1_2 = new long[] {0x63ffffff,0xe0000000,0x0,0x0,0xe0000000,0x0,0x0,0x60000000,0x60000000,0x2000000,0x1ffffff,0x1ffffff,0x3ffffff,0x3ffffff,0x2000000,0x1ffffff,0x0,0x0,0x1ffffff,0x0,0x1ffffff,0x2000000,0x0,0x1ffffff,0x0,0xee000000,0xee000000,0x0,0x0,0x0,0x18000000,0x18000000,};
   }
   private static void jj_la1_init_3() {
      jj_la1_3 = new long[] {0x7600c000,0x1ff3fcf,0x30,0xc000,0x1ff3fcf,0x30,0xc000,0x0,0x0,0x0,0x76000000,0x76000000,0x76000000,0x76000000,0x0,0x76000000,0x0,0x0,0x76000000,0x76000000,0x76000000,0x0,0x76000000,0x0,0x6000000,0x750b,0x750b,0xa000000,0xa000000,0x70000000,0x0,0x0,};
   }
   private static void jj_la1_init_4() {
      jj_la1_4 = new long[] {0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,};
   }

  public SyntaxChecker(System.IO.Stream stream) {
    jj_input_stream = new SimpleCharStream(stream, 1, 1);
    token_source = new SyntaxCheckerTokenManager(jj_input_stream);
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 32; i++) jj_la1[i] = -1;
  }

  public void ReInit(System.IO.Stream stream) {
    jj_input_stream.ReInit(stream, 1, 1);
    token_source.ReInit(jj_input_stream);
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 32; i++) jj_la1[i] = -1;
  }

  public SyntaxChecker(System.IO.TextReader stream) {
    jj_input_stream = new SimpleCharStream(stream, 1, 1);
    token_source = new SyntaxCheckerTokenManager(jj_input_stream);
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 32; i++) jj_la1[i] = -1;
  }

  public void ReInit(System.IO.TextReader stream) {
    jj_input_stream.ReInit(stream, 1, 1);
    token_source.ReInit(jj_input_stream);
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 32; i++) jj_la1[i] = -1;
  }

  public SyntaxChecker(SyntaxCheckerTokenManager tm) {
    token_source = tm;
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 32; i++) jj_la1[i] = -1;
  }

  public void ReInit(SyntaxCheckerTokenManager tm) {
    token_source = tm;
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 32; i++) jj_la1[i] = -1;
  }

  private Token jj_consume_token(int kind){
    Token oldToken;
    if ((oldToken = token).next != null) token = token.next;
    else token = token.next = token_source.getNextToken();
    jj_ntk = -1;
    if (token.kind == kind) {
      jj_gen++;
      return token;
    }
    token = oldToken;
    jj_kind = kind;
    throw generateParseException();
  }

  public Token getNextToken() {
    if (token.next != null) token = token.next;
    else token = token.next = token_source.getNextToken();
    jj_ntk = -1;
    jj_gen++;
    return token;
  }

  public Token getToken(int index) {
    Token t = token;
    for (int i = 0; i < index; i++) {
      if (t.next != null) t = t.next;
      else t = t.next = token_source.getNextToken();
    }
    return t;
  }

  private long jj_init_ntk() {
    if ((jj_nt=token.next) == null)
      return (jj_ntk = (token.next=token_source.getNextToken()).kind);
    else
      return (jj_ntk = jj_nt.kind);
  }

  private System.Collections.Generic.List<long[]> jj_expentries = new System.Collections.Generic.List<long[]>();
  private long[] jj_expentry;
  private long jj_kind = -1;

  public ParseException generateParseException() {
    jj_expentries.Clear();
    bool[] la1tokens = new bool[130];
    for (int i = 0; i < 130; i++) {
      la1tokens[i] = false;
    }
    if (jj_kind >= 0) {
      la1tokens[jj_kind] = true;
      jj_kind = -1;
    }
    for (int i = 0; i < 32; i++) {
      if (jj_la1[i] == jj_gen) {
        for (int j = 0; j < 32; j++) {
          if ((jj_la1_0[i] & (1<<j)) != 0) {
            la1tokens[j] = true;
          }
          if ((jj_la1_1[i] & (1<<j)) != 0) {
            la1tokens[32+j] = true;
          }
          if ((jj_la1_2[i] & (1<<j)) != 0) {
            la1tokens[64+j] = true;
          }
          if ((jj_la1_3[i] & (1<<j)) != 0) {
            la1tokens[96+j] = true;
          }
          if ((jj_la1_4[i] & (1<<j)) != 0) {
            la1tokens[128+j] = true;
          }
        }
      }
    }
    for (int i = 0; i < 130; i++) {
      if (la1tokens[i]) {
        jj_expentry = new long[1];
        jj_expentry[0] = i;
        jj_expentries.Add(jj_expentry);
      }
    }
    long[][] exptokseq = new long[jj_expentries.Count][];
    for (int i = 0; i < jj_expentries.Count; i++) {
      exptokseq[i] = (long[])jj_expentries[i];
    }
    return new ParseException(token, exptokseq, tokenImage);
  }

  public void enable_tracing() {
  }

  public void disable_tracing() {
  }

}
}

