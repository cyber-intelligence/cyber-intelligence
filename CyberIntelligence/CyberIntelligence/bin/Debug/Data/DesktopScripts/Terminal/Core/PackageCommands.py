#region libraris
import Terminal, subprocess, os
#endregion
PackagesPath = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), os.pardir)) + '\\Scripts\\'

#region Private Helpers
def scriptExists(scriptName):
    scriptPath = PackagesPath + scriptName
    return os.path.exists(scriptPath)

def executeScript(args):
    scriptName = args.split()[0]
    scriptPath = PackagesPath + scriptName
    scriptexecutable = open(scriptPath + '.dat').read()
    scriptParameters = args[len(args.split()[0])+1:]
    scriptExecuteCommand = r'cmd /C ' + scriptPath + '\\' + scriptexecutable + ' ' + scriptParameters
    scriptProcess = subprocess.Popen([scriptExecuteCommand], shell=True)
    scriptProcess.wait()
    print('\r\n', end='')

#endregion

def CallScript(cmd):
    if scriptExists(cmd.split()[0]):
        executeScript(cmd)
    else:
        return True