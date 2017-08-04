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

When you run into a situation where you need to use a platform-specific feature from your shared code, you will need to create an abstraction over the feature. Before you go through that effort however, you should look to see if an abstraction already exists. Here are some good places to look:

- [Xamarin.Social](https://github.com/xamarin/Xamarin.Social) The Xamarin.Social component provides an abstraction for popular social networking frameworks such as Facebook and Twitter.
- [Xamarin.Auth](https://github.com/xamarin/Xamarin.Auth)	Xamarin.Auth provides a cross-platform implementation for client-side OAuth interactions.
- [Xamarin.Mobile](https://github.com/xamarin/Xamarin.Mobile)	Xamarin.Mobile provides an abstraction for common mobile services such as the camera.
- [Open source plugins](https://github.com/xamarin/XamarinComponents)	A big list of community-created cross-platform plug-ins.
- [.NET Foundation](https://dotnetfoundation.org/)	The .NET Foundation has a bunch of open-source code.
- [NuGe](https://www.nuget.org/)t	NuGet is the place to find shared binary components
- [Xamarin Component Store](https://components.xamarin.com/)	The Xamarin component store has some commercial binary components.


## [Introduction to Xamarin](https://www.youtube.com/playlist?list=PLZ91tJK_p9B6q-qOBLIk4BhjZSfBxMQm8)
### What is Xamarin.Forms?
### Installing Xamarin
### Pages, Controls and Layout
### Using platform-specific features


## [Introduction to Xamarin.Forms](https://www.youtube.com/playlist?list=PLZ91tJK_p9B6q-qOBLIk4BhjZSfBxMQm8)
##### There are two common approaches to using Xamarin to build mobile applications:
1. The traditional approach where we share primarily business logic and data structures.
2. The Xamarin.Forms approach where we also share the business logic and data structures, but also define the UI using a common set of platform-independent controls - allowing us to also share the UI design.
Let's explore this in a bit more detail together.

##### In Xamarin.forms, remember that each of our applications is made from two components:
__Shared code(Portable Class Library)__ which holds our logic and UI definition and the __Platform-Specific projects__ which are the actual applications we will deploy to the devices and app stores. The PCL is great because it's shared, but it has significant limitations in terms of the APIs we can use.

Many of the platform features which make iOS, Android, and Windows unique are unavailable to us. Those features are available in the platform-specific projects, but then we have to write the code in a non-shared way and try to find some way to "plug" it into our shared UI.

## [Resources and Styles in Xamarin.Forms](https://www.youtube.com/playlist?list=PLZ91tJK_p9B75AFpG2WBmJfXf19pwNfbg)
In these video, we will explore how to use static resiurce in XAML
- Avoid duplicate XAML with Resources
- Create consistent UI with Styles
- Make your Resources and Styles available across your entire app
- Apply the user's accessibility choices with built-in Styles


## [Consuming REST-based Web Services](https://www.youtube.com/playlist?list=PLZ91tJK_p9B5lvSq3Iq3z_PUO_kVFeA2R)
In these video, we will explore REST-Based web request, making HTTP request and handeling data
- Obtain the device's network capabilities
- Introduction to REST
- Consuming REST services with Xamarin
- Integrating with the platform

