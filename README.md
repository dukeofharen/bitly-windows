# Bit.ly client for Microsoft Windows

# [Download Bit.ly for Windows](https://github.com/dukeofharen/bitly-windows/raw/master/latest.zip)

A basic but very nice Bit.ly client for Windows. Bit.ly for Windows resides as an icon in your Windows system tray.

![Bit.ly resides in the Windows system tray](https://raw.githubusercontent.com/dukeofharen/bitly-windows/master/img/systemtray.jpg)

Setup is very easy. Extract the zip file "latest.zip" anywhere you like and start "BitlyWindows.exe". A new icon is now added to your system tray. Right click this icon and select "Settings". You will have to fill in your username and API key. These can be copied from [here](https://bitly.com/a/your_api_key) once you've created a Bit.ly account (which is totally free, even when you want to use your own domain). If the data are correct and you click "Save", the settings box will close and you can start creating short URLs.

If you want to create a short URL, double click the system tray icon and this box will pop up:

![Shorten a URL](https://raw.githubusercontent.com/dukeofharen/bitly-windows/master/img/shorturl.jpg)

Fill in a long URL, hit "Return" and a short URL will be created. Double click the short URL and it will be copied to the clipboard.

Well, that's it, there's nothing more to it. I use this tool to quickly create new short URLs for my blogs or for Twitter.

## Changelog

**Version 0.0.2**
- Added error messages that make more sense.

**Version 0.0.2.1**
- Added error message for when the API key and username aren't set