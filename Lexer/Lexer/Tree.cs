using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer
{
    
    public class Tree<T1, T2, T3> : Branch<T1, T2>
    {
        protected List<Branch<T1, T2>> treebranches = new List<Branch<T1, T2>>(0);
        public ulong depth = 0;
        public Tree()
        {
            this.depth = 0;
            this.treebranches = null;
        }
        public Tree(List<Branch<T1, T2>> branches)
        {
            this.treebranches = branches;
            this.depth = (ulong)treebranches.Count;
        }

        protected Tree<T1, T2, T3> AddBranchYToTree(Branch<T1, T2> branch)
        {
            this.treebranches.Add(branch);
            this.depth++;
            return this;
        }

        protected Tree<T1, T2, T3> Union(Tree<T1, T2, T3> lhs, Tree<T1, T2, T3> rhs)
        {
            Tree<T1, T2, T3> newtree;
            if (lhs.Equals(rhs))
            {
                return this;
            }
            else
            {
                newtree = new Tree<T1, T2, T3>();
                newtree.depth = lhs.depth += rhs.depth;
                newtree.name = lhs.name;
                newtree.Value = lhs.Value;
                newtree.type = EnumTypes.OBJECT;
                for (int i = 0; i < lhs.treebranches.Count; i++)
                {
                    newtree.AddBranchYToTree(lhs.treebranches.ElementAt<Branch<T1, T2>>(i));
                    newtree.depth++;
                }
                for (int j = 0; j < rhs.treebranches.Count; j++)
                {
                    newtree.AddBranchYToTree(rhs.treebranches.ElementAt<Branch<T1, T2>>(j));
                    newtree.depth++;
                }
                return newtree;
            }
        }

        protected Branch<T1, T2> GetBranch(Tree<T1,T2,T3> tree, object criteria = null)
        {
            Branch<T1,T2> b = new Branch<T1,T2>(Program.pubtokens);
            
            if (criteria.Equals(null))
            {
                return tree.treebranches.First<Branch<T1, T2>>();
            }
            else
            {
                return tree.treebranches.FirstOrDefault<Branch<T1,T2>>(c => c.Value.Equals(criteria));
            }
        }

        protected ulong GetTreeDepth(Tree<T1,T2,T3> tree)
        {
            return tree.depth;
        }
    }
}

