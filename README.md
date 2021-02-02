# MP3 Manager - LISP College Project

# Motivation
This is a MP3 Manager application made for a college seminar project.

# Description
The project is an application which allows you to manage mp3 playlists, create new ones, change tracks orders etc.

# Backend
Running `main.lisp`, you can do the following:
- `clisp main.lisp get-playlists` for listing all the available playlists
- `clisp main.lisp get-songs` for listing all the available songs
- `clisp main.lisp get-playlist-songs "playlist"` for listing all the songs in a playlist
- `clisp main.lisp filter-playlists "keyword"` for filtering all the playlist by a keyword
- `clisp main.lisp filter-songs "keyword"` for filtering all the songs by a keyword
- `clisp main.lisp filter-songs-in-playlist "playlist" "songs_keyword"` for filtering all the songs by a keyword from a given playlist
- `clisp main.lisp create-new-playlist "playlsit"` for creating a new playlist
- `clisp main.lisp put-songs-in-playlist "playlsit" "song1" "song2" ...` for adding songs in a playlist
- `clisp main.lisp remove-songs-from-playlist "playlist" "index_song1" "index_song2"` for removing songs from a playlist by the track numbers in that playlist
- `clisp main.lisp move-song-down-in-playlist "playlist" "index_song"` for moving down a track one position in a playlist
- `clisp main.lisp move-song-up-in-playlist "playlist" "index_song"` for moving up a track one position in a playlist

# GUI
Application's interface:

![Main Window](https://i.imgur.com/LsfQ5Fk.png)

