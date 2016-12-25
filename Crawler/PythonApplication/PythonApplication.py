import urllib
import urllib.parse
import urllib.request
import http

url = "https://www.liepin.com/event/landingpage/soejob4landingpage.json"
pdata = {'key': '架构师','dqs': ''}
tmp_pdata=urllib.parse.urlencode(pdata)
req = urllib.request.urlopen(url=url,data=tmp_pdata.encode(encoding="unicode",errors="ignore"))
result = req.read();
print(result)
           
