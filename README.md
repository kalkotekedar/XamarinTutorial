# XamarinTutorial

## [Introduction to Cross-Platform](https://www.youtube.com/playlist?list=PLZ91tJK_p9B7nppFlnwYr0whb521oONRz)
### Using Shared Projects
__Shared Projects__, sometimes referred to as "Shared Application Projects" allow you to define a specific project type where the intent is to actually share all of the files in that project with other projects. It acts just like File Linking – except you only have to add one reference to your target to get all of the files added.
The IDE then treats all the files and assets included in the shared project as if they were part of each of your platform projects. In addition, because the IDE knows about the relationships, all the normal refactoring and navigation tools should work just fine.
The key thing to know about Shared Projects is that they simply define a project container. Unlike all the other project types you typically work with, Shared Projects do not have any output – no EXE or DLL is produced by compiling a shared project. In fact, by itself, the Shared Project isn't even compiled. It must be added to another project in order to have the compiler process the files.
When you add a reference to a shared project, the compiler and build tools will act as if all the files in that shared project were added directly to the target. In other words, the C# source files in the shared project are compiled directly with the target, using that project's build settings.
- The build action you select in the shared project becomes the build action used for each target project.
-	Shared Projects are the preferred way to manage source-level sharing.
-	The only reason to not use them is if you are required to use an older version of the build tools.
-	In order to add references to Shared Projects in Visual Studio 2013, you need an extension.

### Using Portable Class Libraries
__Portable Class Libraries(PCLs)__ attempt to address this problem by creating a library that is capable of running on multiple .NET platforms (Xamarin.iOS, Xamarin.Android, Windows, etc.). They provide a more structured container for sharing code which is not tied to a specific runtime but also require more architecture and thought when using platform-specific features. Let's take a closer look at how these work.


## [Introduction to Xamarin](https://www.youtube.com/playlist?list=PLZ91tJK_p9B6q-qOBLIk4BhjZSfBxMQm8)
### What is Xamarin.Forms?
### Installing Xamarin
### Pages, Controls and Layout
### Using platform-specific features
