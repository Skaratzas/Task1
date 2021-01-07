using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._0._1
{
    class NewBranch
    {
        public NewBranch(Repository repository)
        {
            var branches = repository.Branches;
            Console.WriteLine("\nBranches: ");
            foreach (var branch in branches)
            {
                Console.WriteLine(branch.FriendlyName);
            }
        }
    }
}
