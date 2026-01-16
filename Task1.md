#Task1
---

mkdir carl-zeiss-project 

cd carl-zeiss-project 

mkdir src tests docs
touch README.md .gitignore

cd src
touch main.cpp
cd ..


#git initialisation
---

git init
git status
git add .
git commit -m "Initial project structure"

#push repository to remote repo
---
git remote add origin https://github.com/your-username/carl-zeiss-project.git
git branch -M main
git push -u origin main


#Create a Feature Branch
---
git checkout -b feature-login

nano src/main.cpp
cout<<"hello word;
git add src/main.cpp
git commit -m "Add login feature"
    
git push -u origin feature-login


#Stimulate a Team Change (Another Developer)
---
git checkout main
nano src/main.cpp
cout<<"Main branch update by teammate"
git add src/main.cpp
git commit -m "Update main by teammate"
git push


#Merge 
--- 
git checkout feature-login
git merge main


#Resolve Merge conflict
---
nano src/main.cpp
Fix content to:
cout<<"Login feature added";
cout<<"Main branch update by teammate";

#Final Merge to Main
---
git add .
git commit -m "Fix conflict"
git checkout main
git merge feature-login
git push
