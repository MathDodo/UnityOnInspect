In this asset there are two methods which are called by the editor
- OnInspect 
- OnHierarchyInspect

OnInspect is called on MonoBehaviours automatically when you start inspecting a gameobject, it is also called
on scriptable objects that derive from InspectedSO though if you make a custom editor for your 
scriptable object you need to derive from OnInspectSOInspector.

OnHierarchyInspect will called on MonoBehaviours automatically and will be called when you start inspecting any 
gameobject in a hierarchy 

These methods need to be private and you can have multiple of these methods in a parent child class structure (Inheritance)

There are snippet scripts for these methods in the editor folder inside the snippets folder,
these files can be added to your coding environment like Visual Studio.
