
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;

namespace MSBuildExtension
{
    /// <summary>
    ///     MSBuild task for MSBuildExtension.
    /// </summary>
    public class MSBuildExtensionTask
        : Task
    {
        /// <summary>
        ///     The task's input file.
        /// </summary>
        [Required]
        public ITaskItem InputFile { get; set; }

        /// <summary>
        ///     Receives the input file's content.
        /// </summary>
        [Output]
        public string Content { get; set; }

        /// <summary>
        ///     Execute the task.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if the task executed succesfully; otherwise, <c>false</c>.
        /// </returns>
        public override bool Execute()
        {
            FileInfo inputFile = new FileInfo(
                InputFile.GetMetadata("FullPath")
            );
            if (!inputFile.Exists)
            {
                Log.LogError($"Input file '{inputFile.FullName}' not found.");

                return false;
            }

            using (StreamReader reader = inputFile.OpenText())
            {
                Content = reader.ReadToEnd();
            }

            return true;
        }
    }
}