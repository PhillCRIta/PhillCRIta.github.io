# PhillCRIta.github.io
MyPersonalSite


Appunti GIT:

INIZIALIZZAZIONE NUOVO REPO\
$ git init (nella cartella in cui mi trovo si crea il repo)\
$ git --bare init [nome cartella]  (crea un repo vuoto su un server remoto, pronto a ospitare i push da git locale)\

VARIO\
$ git status (ottengo lo stato di archiviazione del repo locale/remoto)\
$ git log (ottengo il log esteso di tutti i commit fatti)\
$ git log --oneline (ottengo il log semplificato di tutti i commit fatti)\
$ git branch -avvv (ottengo lo stato di tutti i remote e di tutti i rami)\

BRANCH\
$ git switch [nome ramo] (cambia il ramo sul repo)\

REMOTE\
Aggiungere un remote\
$ git remote add [nome] [url] (di default il nome dato è origin)\
Elenco di tutti i remote configurati\
$ git remote -v \
$ git remote rename [vecchio nome] [nuovo nome]\
$ git remote remove [nome]\

PUSH SU SERVER REMOTO GitHub o altro server\
Quando si fa il push si carica il ramo in cui si sta lavorando su un server remoto Git.\
$ git push [nome remoto] [ramo da caricare]\