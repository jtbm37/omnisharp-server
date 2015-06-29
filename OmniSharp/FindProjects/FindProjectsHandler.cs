using System.Collections.Generic;
using System.Linq;
using OmniSharp.Common;
using OmniSharp.Solution;

namespace OmniSharp.FindProjects
{
    public class FindProjectsHandler
    {
        readonly ISolution _solution;
<<<<<<< HEAD
=======

>>>>>>> upstream
        public FindProjectsHandler(ISolution solution)
        {
            _solution = solution;
        }

<<<<<<< HEAD
        public QuickFixResponse FindAllProjects()
        {
            
            var quickfixes = _solution.Projects
                .Where(x => x.Title != OrphanProject.ProjectFileName)
                .OrderBy(x => x.Title)
                .Select(t => new QuickFix
                {
                    Text = t.Title,
                    FileName = t.FileName
                });

            return new QuickFixResponse(quickfixes);
        }
        
=======
        public FindProjectsResponse FindAllProjects()
        {
            var projects = _solution.Projects
                .Where(x => x.Title != OrphanProject.ProjectFileName)
                .OrderBy(x => x.Title)
                .Select(t => new MsBuildProject(t));
            return new FindProjectsResponse { MSBuild = new MsBuildWorkspaceInformation{ Projects = projects }};
        }
>>>>>>> upstream
    }
}
