using System;
using System.Diagnostics;
using System.IO;

public class AxSysJobRunner
{
    private readonly string axEnginePath;
    private readonly string adDirectory;

    public AxSysJobRunner(string axEnginePath, string adDirectory)
    {
        this.axEnginePath = axEnginePath;
        this.adDirectory = adDirectory;
        Directory.CreateDirectory(adDirectory);
    }

    public string GenerateJobScript(string filename, string[] lines)
    {
        string fullPath = Path.Combine(adDirectory, filename);
        File.WriteAllLines(fullPath, lines);
        return fullPath;
    }

    public bool RunJob(string adFilePath, out string errorMessage)
    {
        errorMessage = string.Empty;

        if (!File.Exists(axEnginePath))
        {
            errorMessage = "AxEngine.exe not found.";
            return false;
        }

        if (!File.Exists(adFilePath))
        {
            errorMessage = "Script file not found: " + adFilePath;
            return false;
        }

        try
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = axEnginePath,
                    Arguments = $"\"{adFilePath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            process.WaitForExit();

            return process.ExitCode == 0;
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
            return false;
        }
    }
}
