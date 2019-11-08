#region libraris
import os, socket
import Terminal
from colorama import Fore, Back, Style, init
#endregion

#region commands
def pwd():
    print(Terminal.dir)

def ping(args):
    os.system(args)
    print('\n')

def clear():
    print(chr(27) + "[2J", end='')

def echo(args):
    echoOutput = args.replace('echo ','')
    print(f"{echoOutput}\n")

def ls(args):
    files = os.listdir(Terminal.dir)
    files.sort()
    i = 0
    for name in files:
        if('.' in name):
            print(Fore.LIGHTGREEN_EX, end='')
        else:
            print(Fore.LIGHTBLUE_EX, end='')
        
        i+=1        
        print((name + ' ').ljust(40), end='')

        if(len(name) >= 40):
            print('\r')
            i=0

        if(i >= 2):
            i=0
            print('\r')
    
    i=0
    print(Fore.WHITE + '\r\n\r')

def resolve(args):
    ip = socket.gethostbyname(args.split()[1])
    print(ip, end='\n\n')

def cd(cmd):

    new_dir = get_new_dir(cmd).replace('\\\\','\\')

    if os.path.exists(new_dir):
        Terminal.dir = new_dir
    else:
        print('The system cannot find the path specified.\n')

def cat(args):
    filename = args.split()[1]
    content = open(Terminal.dir + filename).read()
    print(content, end='\r\n\r\n')
    

def help():
    helpDialog = """help \t\t\tShow this help dialog
clear\t\t\tClear terminal menu
cd\t\t\tChange directory
pwd\t\t\tShow current directory
ls\t\t\tShow files and directories in current path
cat\t\t\tRead file contents
echo\t\t\tDisplays a text
resolve\t\t\tResolve domain ip address
ping\t\t\tPing a specified host
    \n"""
    print(helpDialog)
#endregion

#region Private Helpers

def get_new_dir(cmd):
    path = cmd[3:]

    if os.path.exists(path):
        return path

    if path == '..':
        tdir_split = Terminal.dir.split('\\')
        del tdir_split[-2]
        new_path = concatenate_list_data([dir + '\\' for dir in tdir_split])
        print(new_path)
        return new_path

    path = path.replace('/', '\\')
    if not path.endswith('\\'):
        path = path + '\\'

    return Terminal.dir + path


def concatenate_list_data(list):
    result= ''
    for element in list:
        result += str(element)
    return result
#endregion

def ProcessCMD(cmd):
    if cmd == '':
        print('', end='')
    elif cmd.startswith('pwd'):
        pwd()
    elif cmd == 'exit':
        exit()
    elif cmd.startswith('ping'):
        ping(cmd)
    elif cmd == 'clear':
        clear()
    elif cmd.startswith('help'):
        help()
    elif cmd.startswith('echo'):
        echo(cmd)
    elif cmd.startswith('resolve '):
        resolve(cmd)
    elif cmd.startswith('ls') :
        ls(cmd)
    elif cmd.startswith('cd'):
        cd(cmd)
    elif cmd.startswith('cat'):
        cat(cmd)
    else:        
        return True