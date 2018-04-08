# fanfic-scraper (Fanfic Downloader)
Downloads fanfics from various websites.
Currently supports fanfiction.net (more coming up soon).

### Installation

Clone a copy of the repository using the following command:

```
git clone https://github.com/KebinuChiousu/FanfictionDB.git
```

#### Requirements
The script is written in python. It requires the following packages:
1. BeautifulSoup4
2. requests
3. futures (concurrent.futures)

These can simply be installed by running in the FFScraper folder.
```
pip install -r requirements.txt
```

That's it. Use fanfic_scraper.py to download fanfics.

## Usage

Find your fanfic of interest at fanfiction.net. Copy the url of the story (https supported).
For example, If I wanted to download the story "Magical Player".  manga, I need to copy this url:
https://www.fanfiction.net/s/12861961/1/Magical-Player

To download all the chapters of the comic, simply call the script and input the url.
```
fanfic-scraper https://www.fanfiction.net/s/12861961/1/Magical-Player
```

If you want to set a custom location, add -l and input the location
```
fanfic-scraper -l ~/Fanfics/ https://www.fanfiction.net/s/12861961/1/Magical-Player
```

If you want to download a select few chapters, add -c and input the chapter numbers.
For example, if I want to download chapters 10-15, I use the following command

```
fanfic-scraper -l ~/Fanfics/ -c 10:15 https://www.fanfiction.net/s/12861961/1/Magical-Player
```
Note: Only individual chapters or sequential chunks (start:stop) can currently be downloaded.