using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._0._1
{
    class NewCommit
    {
        public NewCommit(Repository repository)
        {
            var commits = repository.Commits;
            Console.WriteLine("Commits: ");
            foreach (var commit in commits)
            {
                Console.WriteLine($"{commit.Id.ToString().Substring(0, 6)} " +
                                  $"{commit.Author.When.ToLocalTime()} " +
                                  $"{commit.MessageShort} " +
                                  $"{commit.Author.Name}");
            }
        }
    }
}
