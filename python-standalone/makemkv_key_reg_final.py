import os
import requests
from bs4 import BeautifulSoup
import winreg

# Fetch the web page HTML
response = requests.get('https://forum.makemkv.com/forum/viewtopic.php?f=5&t=1053')
html = response.content

# Parse the HTML with BeautifulSoup
soup = BeautifulSoup(html, 'html.parser')

# Find the first <code> block and extract its contents as the key value
key_value = soup.find('code').text

# Update the registry with the key value
key = winreg.CreateKey(winreg.HKEY_CURRENT_USER, r'Software\MakeMKV')
winreg.SetValueEx(key, 'app_Key', 0, winreg.REG_SZ, key_value)
winreg.CloseKey(key)

# Print a message to the console
print('##################################')
print('The key has been added to MakeMKV')
print('##################################')
    
# Wait for the user to press Enter before exiting
input('\nPress Enter to exit...')

###########################################
## Created by MiTechMess.com
## All credit goes to the owner of MakeMKV
###########################################
