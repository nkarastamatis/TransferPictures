
function prompt { "$pwd>" }

prompt
git add .
git commit -a -m $Args[0]
git push

cd ..\AndroidLib-master
prompt
git add .
git commit -a -m $Args[0]
git push

cd ..\MediaLib
prompt
git add .
git commit -a -m $Args[0]
git push

cd ..\TransferPictures