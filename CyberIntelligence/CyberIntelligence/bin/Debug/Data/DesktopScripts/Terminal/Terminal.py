#region libraries
from Core import ProcessCommand
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
    print(Fore.RED + f"{username}@{host}" + Fore.WHITE + ":" + Fore.BLUE + "~" + Fore.WHITE + "# ", end='')
    return input('')
#endregion

#region Main
def main():
    while True:
        command = getCMD()
        ProcessCommand.ProcessCMD(command)
        
#endregion

#region CTor
if __name__ == '__main__':
    init()
    main()
#endregion