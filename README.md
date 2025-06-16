
# Developer test
Hi welcome to our developer test phase, you'll find avobe the all the information you can need in order to get started.

## Software requiremnts

In order to be able to complete this test you'll need to have installed Visual studio 2022 with .NET core 8.0, also you need to have Git on your local machine in order to get the repository code


## Set up your environment


Clone the project

```bash
  git clone https://github.com/foundeverCo/DeveloperTest.git
```

Go to the project directory

```bash
  cd DeveloperTest
```

Create your branch checkout to it

```bash
  git checkout -b FirstName_LastName
```

If you were not able to clone the repository you can download it by clicking [here](https://github.com/foundeverCo/DeveloperTest/archive/refs/heads/main.zip), once you finish the exercises you'll add the project into a .zip file and send it over to the team email.

If you got to this point you should be able to start with the exercises, good luck.


**Warning:** is recommendable to first build the solution in order to refresh physical paths in the project


**Once you finish all the exercises and you are ready to push them**

```bash
  git add .
  git commit -m "Submiting developer test"
  git push origin FirstName_LastName
```

## Developer test

#### Exercise 1

Expand the ``ProgrammingLogic`` project and open the 01.cs and 02.cs classes, read the exercise and build the requested logic.

This project contains a file called ``Program.cs`` from where you'll be able to test both functions and see what your function outputs (you need to expand each exercise section).

#### Exercise 2

Expand the ``FrontEnd`` project and open the ``HomeController`` and the ``Views/Home/Index.cshtml`` file, read the exercise and build the requested features

#### Exercise 3

Expand the ``Pokemon.cshtml`` file located in ``FrontEnd/Views/Home`` and complete the requested exercise

#### Exercise 4

On the file ``Index.cshtml`` located in the ``FrontEnd/Views/Admin`` folder, there's an compilation error that prompts to the user every time any user tries to open it, found the related error and fix it

Aditionally for some reason users like "Felipe Castro" which should have an scope of ``public`` are being showed as ``private`` found the reason and solve it

## Switching projects

This solution contains a project called ``ProgrammingLogic`` which is a console application and the default startup project; Once you get to the **Exercise 2** you'll need to set the ``FrontEnd`` project as the start up project, you can do it by right-clicking the ``FrontEnd`` project and selecting **Set as Startup Project**
![06](https://github.com/foundeverCo/DeveloperTest/blob/main/Images/06.png)
![05](https://github.com/foundeverCo/DeveloperTest/blob/main/Images/05.png)

## Test cases

The ``Exercise 1`` contains a series of test cases, **this test cases are not mandatory**; if you don't know how to run them we have some documentation [here](https://github.com/foundeverCo/DeveloperTest/tree/main/Test)
