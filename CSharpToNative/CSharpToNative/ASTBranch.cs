using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToNative
{
    public class ASTBranch<T1, T2, T3, T4> : Branch<T1, T2>
    {
        bool isroot = false;
        //static Type T4;
        public ASTBranch()
        {
            try
            {
                throw new InvalidOperationException("Cannot Create a branch without tokens or tree");
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
        }
        public ASTBranch(string[] tokens, AST<T1, T2, T3, T4> tree)
        {
            int protval = Convert.ToInt32(tokens[0]);
            int typeval = Convert.ToInt32(tokens[1]);
            int opval = Convert.ToInt32(tokens[2]);
            if (protval > 2)
            {
                this.protectionlevel = EnumAccessModifiers.NO_MODIFIER;
            }
            else
            {
                this.protectionlevel = (EnumAccessModifiers)Convert.ToInt32(tokens[0]);
            }

            if (typeval > 12)
            {
                this.type = EnumTypes.NO_TYPE;
            }
            else
            {
                this.type = (EnumTypes)Convert.ToInt32(tokens[1]);
            }
            
            this.name = tokens[2];
            if (opval > 36)
            {
                this.operation = EnumOperator.NO_OPERATOR;
            }
            else
            {
                this.operation = (EnumOperator)Convert.ToInt32(tokens[3]);
            }
            
            this.Value = tokens[4];
            if (tree.treebranches.Count.Equals(0))
            {
                this.isroot = true;
            }
            else
            {
                this.isroot = false;
            }
            tree.treebranches.Add((Branch<T1, T2>)this);
        }

    }
}
