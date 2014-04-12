using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer
{
    public class ASTBranch<T1,T2,T3> : Branch<T1,T2>
    {
        bool isroot = false;
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
        public ASTBranch(string[] tokens,AST<T1,T2,object,object> tree)
        {
            this.protectionlevel = (EnumAccessModifiers)Convert.ToInt32(tokens[0]);
            this.type = ((EnumTypes)Convert.ToInt32(tokens[1]));
            this.name = tokens[2];
            this.Value = tokens[4];
            if (tree.treebranches.Count.Equals(0))
            {
                this.isroot = true;
            }
            else
            {
                this.isroot = false;
            }
            tree.treebranches.Add((Branch<T1,T2>)this);
        }

    }
}
