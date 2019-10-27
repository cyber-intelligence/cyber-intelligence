#region libraris
import os
import Terminal
import pprint
#endregion


#region commands
def pwd():
    print(Terminal.dir)

def ping(args):
    os.system(args)
    print('\n')

def clear():
    print(chr(27) + "[2J", end=None)

def echo(args):
    os.system(args)

def ls(args):
    ls_sorts = os.listdir(Terminal.dir)
    ls_size  = os.stat(Terminal.dir)
    
    ls_printabless = dict(zip(ls_sorts, ls_size))
    pp = pprint.PrettyPrinter(indent=4)
    pp.pprint(ls_printabless)

def cd(cmd):
    
    new_dir = get_new_dir(cmd)

    if os.path.exists(new_dir):
        Terminal.dir = new_dir
    else:
        print('The system cannot find the path specified.')

    

def help():
    helpDialog = """
    help \t\tShow this help dialog
    ping \t\tPing a specified host
    clear\t\tClear terminal menu
    pwd  \t\tShow current directory
    \n"""
    print(helpDialog)
#endregion


#region Private Helpers

def get_new_dir(cmd):
    path = cmd[3:]

    # age path .. bod, boro ye folder aghab tar
    # if path == '..':

    if not path.endswith('\\'):
        path = path + '\\'

    return Terminal.dir + path



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
    elif cmd.startswith('ls') :
        ls(cmd)
    elif cmd.startswith('cd'):
        cd(cmd)
    else:
        print(f"'{cmd}' Command not found!\n")