// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Tools.Sln
{
    internal class LocalizableStrings
    {
        public const string AppFullName = ".NET modify solution file command";

        public const string AppDescription = "Command to add, remove, and list projects from the solution (SLN) file.";

        public const string AppHelpText = "Projects to add to the solution.";

        public const string CmdSlnFile = "<SLN_FILE>";
        
        public const string AddAppFullName = ".NET Add project to a solution file Command";
        public const string AddSubcommandHelpText = "Add a specified project to the solution.";

        public const string RemoveAppFullName = ".NET Remove project from a solution file Command";
        public const string RemoveSubcommandHelpText = "Remove the specified project from the solution. The project is not impacted.";
        
        public const string ListAppFullName = ".NET List project(s) in a solution file Command";
        public const string ListSubcommandHelpText = "List all projects in the solution.";

        public const string CreateAppFullName = ".NET Create a solution file Command";
        public const string CreateSubcommandHelpText = "Create a solution file.";

        public const string MultipleSlnFilesError = "The current directory contains more than one solution file. Please specify the solution file to use.";

        public const string ProjectFileNotFoundError = "The specified project {0} was not found.";

        public const string SolutionFileNotFoundError = "The specified solution file {0} was not found.";

        public const string NoSolutionFileError = "The current directory does not contain a solution file. Please specify a solution file to use.";
    }
}
