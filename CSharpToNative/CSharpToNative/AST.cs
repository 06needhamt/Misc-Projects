using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
    public class AST<T1, T2, T3, T4> : Tree<T1, T2, T3>
    {

        //Branch<T1,T2> root = new Branch<T1,T2>(Program.pubtokens);
        //AST<T1,T2,T3,T4> def = new AST<T1,T2,T3,T4>();
        ASTBranch<T1, T2, T3, T4> root;
        ASTBranch<T1, T2, T3, T4> leftchild;
        ASTBranch<T1, T2, T3, T4> rightchild;
        public AST()
        {

            root = new ASTBranch<T1, T2, T3, T4>(Lexer.pubtokens, this);
            leftchild = new ASTBranch<T1, T2, T3, T4>(Lexer.pubtokens, this);
            rightchild = new ASTBranch<T1, T2, T3, T4>(Lexer.pubtokens, this);
        }
        protected void seroot(ASTBranch<T1, T2, T3, T4> newroot)
        {
            if (newroot.parent != null)
            {
                root = newroot;
                root.parent = null;
                newroot.parent = null;
            }
            else
            {
                try
                {
                    throw new InvalidOperationException("THE BRANCH IS ALREADY THE ROOT OF THIS TREE");
                }
                catch (InvalidOperationException ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(ex.GetType());
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.ResetColor();
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("FATAL ERROR THE BRANCH IS ALREADY THE ROOT OF THIS TREE EXITING");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(2500);
                    Environment.Exit(-1);
                }
            }
        }
        protected ASTBranch<T1, T2, T3, T4> getroot(AST<T1, T2, T3, T4> tree)
        {
            foreach (ASTBranch<T1, T2, T3, T4> branch in tree.treebranches)
            {
                if (branch.parent.Equals(null))
                {
                    return branch;
                }
                else
                {
                    continue;
                }
            }
            return null; 
            /*new String(new char[]  { 'n','o',' ','r','o','o','t' });*/
        }
        protected bool executebranch(ASTBranch<T1,T2,T3,T4> branch)
        {
            string varname = branch.name;
            EnumTypes type = branch.type;
            EnumOperator operation = branch.operation;
            Object value = branch.Value;
            if(IsNumerical(type))
            {
                CreateInstruction(type,operation,varname,value);
            }
            return false;
        }

        private void CreateInstruction(EnumTypes Type , EnumOperator operation , string name, Object val)
        {
            DefineVariable(type,name,null);
        }

        private static dynamic DefineVariable(EnumTypes Type, string name, Object val = null)
        {
           // System.Type var = val.GetType();
            dynamic memory = val;
            return memory;
        }

        private bool IsNumerical(EnumTypes Type)
        {
            int[] numericaltypes = { 0, 3, 4, 5, 6, 9, 11 };
            return (numericaltypes.Contains<int> (Convert.ToInt32(Type)));
        }
    }
}
