; -= HELPER FUNCTIONS =-
(defun substringp (to-find in-text &key (test 'char=))
	(search 
		(string to-find)
		(string in-text)
		:test test
	)
)

(defun remove-nth-element (index elements)
	(append
		(subseq elements 0 (1- (+ index 1)))
		(nthcdr (+ index 1) elements)
	)
)

(defun insert-at-position-in-list-new-element (index elements new-element)
	(let 
		((retval nil))
		(loop for i from 0 to (- (length elements) 1) do
			(when 
				(= i index)
				(push new-element retval)
			)
			(push (nth i elements) retval)
		)
		(when
			(>= index (length elements))
			(push new-element retval)
		)
		(nreverse retval)
	)
)

; -= END OF HELPER FUNCTIONS =-

; -= PROGRAM FUNCTIONALITIES =-

(defun get-playlists ()
	(dolist
		(file
			(directory
				(make-pathname :name :wild :type :wild :defaults "playlists/")
			)
		)
		(write-string (pathname-name file))
		(terpri)
	)
)

(defun get-songs ()
	(dolist
		(file
			(directory
				(make-pathname :name :wild :type :wild :defaults "songs/")
			)
		)
		(write-string (pathname-name file))
		(terpri)
	)
)

(defun get-playlist-songs (playlist)
	(with-open-file
		(fis
			(concatenate `string "playlists/" playlist ".txt")
		)
		(do
			((song (read-line fis nil)
				   (read-line fis nil)))
			((null song))
			(write-string song)
			(terpri)
		)
	)
)

(defun filter-playlists (playlist)
	(dolist
		(file
			(directory
				(make-pathname :name :wild :type :wild :defaults "playlists/")
			)
		)
		(if
			(substringp playlist (pathname-name file))
			(progn
				(write-string (pathname-name file))
				(terpri)
			)
		)
	)
)

(defun filter-songs (song)
	(dolist
		(file
			(directory
				(make-pathname :name :wild :type :wild :defaults "songs/")
			)
		)
		(if
			(substringp song (pathname-name file))
			(progn
				(write-string (pathname-name file))
				(terpri)
			)
		)
	)
)

(defun filter-songs-in-playlist (playlist song)
	(with-open-file
		(fis
			(concatenate `string "playlists/" playlist ".txt")
		)
		(do
			((line (read-line fis nil)
				   (read-line fis nil)))
			((null line))
			(if 
				(substringp song line)
				(progn
					(write-string line)
					(terpri)
				)
			)
		)
	)
)

(defun create-new-playlist (playlist)
	(with-open-file
		(create-file
			(concatenate `string "playlists/" playlist ".txt") :direction :output
		)
	)
)

(defun put-songs-in-playlist (playlist songs)
	(if
		(not (null songs))
		(progn
			(with-open-file 
				(fos
					(concatenate `string "playlists/" playlist ".txt")
					:direction :output :if-exists :append :if-does-not-exist :create
				)
				(write-string (car songs) fos)
				(terpri fos)
			)
			(put-songs-in-playlist playlist (cdr songs))
		)
	)
)

(defun remove-songs-from-playlist (playlist songs-to-remove)
	(with-open-file
		(fis
			(concatenate `string "playlists/" playlist ".txt")
		)
		(setq 
			parsed-songs
			(loop
				for line-number from 0
				for song = (read-line fis nil nil)
				while song
				unless (member line-number (mapcar #'parse-integer songs-to-remove))
				collect song
			)
		)
	)
	(with-open-file
		(fos
			(concatenate `string "playlists/" playlist ".txt")
			:direction :output :if-exists :supersede
		)
		(dolist
			(song parsed-songs)
			(write-string song fos)
			(terpri fos)
		)
	)
)

(defun move-song-down-in-playlist (playlist song-index)
	(with-open-file
		(fis
			(concatenate `string "playlists/" playlist ".txt")
		)
		(setq 
			parsed-songs
			(loop
				for line-number from 1
				for song = (read-line fis nil nil)
				while song
				collect song
			)
		)
	)
	(setq song-index (parse-integer song-index))
	(if
		(and
			(>= song-index 0)
			(< song-index (length parsed-songs))
		)
		(progn
			(setq
				parsed-songs
				(insert-at-position-in-list-new-element
					(+ song-index 1)
					(remove-nth-element song-index parsed-songs)
					(nth song-index parsed-songs)
				)
			)
			(with-open-file
				(fos
					(concatenate `string "playlists/" playlist ".txt")
					:direction :output :if-exists :supersede
				)
				(dolist
					(song parsed-songs)
					(write-string song fos)
					(terpri fos)
				)
			)
		)
	)
)

(defun move-song-up-in-playlist (playlist song-index)
	(with-open-file
		(fis
			(concatenate `string "playlists/" playlist ".txt")
		)
		(setq
			parsed-songs
			(loop
				for line-number from 1
				for song = (read-line fis nil nil)
				while song
				collect song
			)
		)
	)
	(setq song-index (parse-integer song-index))
	(if
		(and
			(> song-index 0)
			(<= song-index (length parsed-songs))
		)
		(progn
			(setq 
				parsed-songs
				(insert-at-position-in-list-new-element
					(- song-index 1)
					(remove-nth-element song-index parsed-songs)
					(nth song-index parsed-songs)
				)
			)
			(with-open-file
				(fos
					(concatenate `string "playlists/" playlist ".txt")
					:direction :output :if-exists :supersede
				)
				(dolist
					(song parsed-songs)
					(write-string song fos)
					(terpri fos)
				)
			)
		)
	)
)

; -= END OF PROGRAM FUNCTIONALITIES =-

; -= MAIN =-

(cond
	(
		(string= "get-playlists" (car *args*))
		(get-playlists)
	)
	(
		(string= "get-songs" (car *args*))
		(get-songs)
	)
	(
		(string= "get-playlist-songs" (car *args*))
		(get-playlist-songs (car (cdr *args*)))
	)
	(
		(string= "filter-playlists" (car *args*))
		(filter-playlists (car (cdr *args*)))
	)
	(
		(string= "filter-songs" (car *args*))
		(filter-songs (car (cdr *args*)))
	)
	(
		(string= "filter-songs-in-playlist" (car *args*))
		(filter-songs-in-playlist (car (cdr *args*)) (car (cdr (cdr *args*))))
	)
	(
		(string= "create-new-playlist" (car *args*))
		(create-new-playlist (car (cdr *args*)))
	)
	(
		(string= "put-songs-in-playlist" (car *args*))
		(put-songs-in-playlist (car (cdr *args*)) (cdr (cdr *args*)))
	)
	(
		(string= "remove-songs-from-playlist" (car *args*))
		(remove-songs-from-playlist (car (cdr *args*)) (cdr (cdr *args*)))
	)
	(
		(string= "move-song-down-in-playlist" (car *args*))
		(move-song-down-in-playlist (car (cdr *args*)) (car (cdr (cdr *args*))))
	)
	(
		(string= "move-song-up-in-playlist" (car *args*))
		(move-song-up-in-playlist (car (cdr *args*)) (car (cdr (cdr *args*))))
	)
)

; -= END OF MAIN =-
