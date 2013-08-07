How to use custom configuration
===============================

Prototype projects illustrating how to access custom configuration sections from a .NET configuration file.

There are 3 projects which show escalating complexity in custom configuration.

The first project 'HowToUseCustomConfiguration.1.CustomSection' illustrates how to get attributes from a custom configuration section.

The second project 'HowToUseCustomConfiguration.2.NestedElement' illustrates how to get attributes from a custom configuration section along with a nested custom element.

The third project 'HowToUseCustomConfiguration.3.NestedElementsCollection' illustrates how to get attributes from a custom configuration section along with a nested custom element acting as a AddRemoveClearMap type collection.

I'll create a 4th project to illustrate the BasicMap element collection when I need it ... but seeing as how I've gone this long without needing it, it's not likely to come anytime soon.

To get an idea what each project is all about, you can look at the config file.  You can step through it by putting a breakpoint in the program.cs file.  All other files are part of the custom configuration functionality.

One last hint, you can see the differences by diffing each directory 1 against 2, and 2 against 3.