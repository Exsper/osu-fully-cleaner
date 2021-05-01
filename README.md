# osu-fully-cleaner

Another version of [henntix's osu-cleaner](https://github.com/henntix/osu-cleaner/)

Delete all files except .osu and .mp3 files!

## Replace Background file
You can replace beatmap's BG with custom file, just edit the files in "replace" folder, but do not change these files' names!

## Issue
I couldn't deal with the long filepath like
```
"F:\osu!\Songs\580478 LiaAoi TadaKawada MamiShimamiya EikoKOTOKOUtatsuki KaoriChataRitaLiSA - Orpheus ~Kimi to Kanaderu Ashita e no Uta~\Artists - Orpheus ~Kimi to Kanaderu Ashita e no Uta~ (Shurelia) [Hymn To The World].osu"
```
File.OpenText report an error