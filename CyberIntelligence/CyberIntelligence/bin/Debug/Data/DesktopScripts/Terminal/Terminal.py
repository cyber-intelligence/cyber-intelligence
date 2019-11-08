#region libraries
from Core import ProcessCommand, PackageCommands
from time import sleep
import getpass
import os
from colorama import Fore, Back, Style, init
#endregion

#region global variables
dir = os.path.abspath(os.sep)

#endregion

#region functions
def getCMD():
    username = getpass.getuser()
    host = 'CIF'
    print(Fore.LIGHTRED_EX + username + Fore.RED + "@" + Fore.LIGHTRED_EX + host + Fore.LIGHTWHITE_EX + ":" + Fore.LIGHTBLUE_EX + "~" + Fore.LIGHTWHITE_EX + "# " + Fore.WHITE, end='')
    return input('')
#endregion

#region Main
def main():
    while True:
        command = getCMD()
        not_sys_command = ProcessCommand.ProcessCMD(command)
        if not_sys_command:
            invalid_script = PackageCommands.CallScript(command)
            if invalid_script:
                print(f"'{command}' Command not found!\n")

        
#endregion

#region CTor
if __name__ == '__main__':
    init()
    main()
#endregion