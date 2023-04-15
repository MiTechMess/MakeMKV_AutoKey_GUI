import os
import requests
from bs4 import BeautifulSoup
import winreg
import traceback

try:
    
    # Fetch the web page HTML
    response = requests.get('https://forum.makemkv.com/forum/viewtopic.php?f=5&t=1053')
    html = response.content

    # Parse the HTML with BeautifulSoup
    soup = BeautifulSoup(html, 'html.parser')

    # Find the first <code> block and extract its contents as the key value
    key_value = soup.find('code').text

    # Open the registry key and delete the existing value, if any
    key = winreg.OpenKey(winreg.HKEY_CURRENT_USER, r'Software\MakeMKV', 0, winreg.KEY_SET_VALUE)
    try:
        winreg.DeleteValue(key, 'app_Key')
    except OSError:
        pass

    # Update the registry with the new key value
    winreg.SetValueEx(key, 'app_Key', 0, winreg.REG_SZ, key_value)
    winreg.CloseKey(key)

    # Print a message to the console
    print('key_added')

except Exception as e:
    # Print the traceback of any error that occurs
    traceback.print_exc()

###########################################
## Created by MiTechMess.com
## All credit goes to the owner of MakeMKV
###########################################