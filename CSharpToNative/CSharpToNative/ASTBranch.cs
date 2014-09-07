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
            if ((int)EnumAccessModifiers.PRIVATE != Convert.ToInt32(tokens[0]) && (int)EnumAccessModifiers.PROTECTED != Convert.ToInt32(tokens[0]) && (int)EnumAccessModifiers.PUBLIC != Convert.ToInt32(tokens[0]))
            {
                this.protectionlevel = EnumAccessModifiers.NO_MODIFIER;
            }
            else
            {
                this.protectionlevel = (EnumAccessModifiers)Convert.ToInt32(tokens[0]);
            }

            
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
            tree.treebranches.Add((Branch<T1, T2>)this);
        }

    }
}
