#region libraries
from Core import ProcessCommand
from time import sleep
import getpass
import os
from colorama import Fore, Back, Style, init
#endregion

#region global variables
dir = ""

#endregion

#region functions
def getCMD():    
    username = getpass.getuser()
    host = 'CIF'
    print(Fore.RED + f"{username}@{host}" + Fore.WHITE + ":" + Fore.BLUE + "~" + Fore.WHITE + "# ", end='')
    return input('')

def getRootPath():
    return os.path.abspath(os.sep)
#endregion

#region Main
def main():
    global dir
    dir = 
    while True:
        command = getCMD()
        ProcessCommand.ProcessCMD(command)
        
#endregion

#region CTor
if __name__ == '__main__':
    init()
    main()
#endregion