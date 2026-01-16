# Problem Statement

You have joined **Carl Zeiss** as a **Junior Developer**. On your first day, your team lead assigns you a task to simulate a real-world development workflow.

## Your Responsibilities

- Set up a project structure using Linux commands.
- Initialize a Git repository for version control.
- Push the project to GitHub.
- Create a feature branch and add new code.
- Simulate a team change by modifying the same file from another branch.
- Merge the code and handle any conflicts.
- Resolve the merge conflict and complete the merge successfully.
 
---

# Solution

This solution demonstrates a complete real-world development workflow using Linux and Git.

## Set Up Project Structure (Linux)

```bash
mkdir carl-zeiss-project
cd carl-zeiss-project
mkdir src tests docs
touch README.md .gitignore
cd src
touch main.cpp
cd ..
```

## Git initialisation
---
```bash
git init
git status
git add .
git commit -m "Initial project structure"
```

## Push repository to remote repository
---
```bash
git remote add origin https://github.com/your-username/carl-zeiss-project.git
git branch -M main
git push -u origin main
```

## Create a Feature Branch
---

```bash
git checkout -b feature-login

nano src/main.cpp
cout<<"hello word;
git add src/main.cpp
git commit -m "Add login feature"
    
git push -u origin feature-login
```


## Stimulate a Team Change (Another Developer)
---

```bash
git checkout main
nano src/main.cpp
cout<<"Main branch update by teammate"
git add src/main.cpp
git commit -m "Update main by teammate"
git push
```

## Merge 
--- 

```bash
git checkout feature-login
git merge main
```

## Resolve Merge conflict
---

```bash
nano src/main.cpp
Fix content to:
cout<<"Login feature added";
cout<<"Main branch update by teammate";
```

## Final Merge to Main
---

```bash
git add .
git commit -m "Fix conflict"
git checkout main
git merge feature-login
git push
```
