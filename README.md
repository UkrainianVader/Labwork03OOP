# ThreeDimVectorProject

This project implements a three-dimensional vector class in C#. The `Vector3D` class allows for the creation and manipulation of vectors in a 3D space, including the ability to determine the largest vector among a collection of vectors.

## Project Structure

- **src/**: Contains the source code files.
  - **Program.cs**: The entry point of the application, demonstrating the usage of the `Vector3D` class.
  - **Vector3D.cs**: Defines the `Vector3D` class with properties for x, y, and z coordinates, a constructor, a destructor, and methods for calculating magnitude and finding the largest vector.
  
- **ThreeDimVectorProject.csproj**: The project file containing configuration settings for the C# application.

## Building the Project

To build the project, use the following command in the terminal:

```
dotnet build
```

## Running the Project

After building, you can run the project with the following command:

```
dotnet run --project src/ThreeDimVectorProject.csproj
```

## Usage Example

Here is a brief example of how to create instances of the `Vector3D` class and find the largest vector:

```csharp
Vector3D vector1 = new Vector3D(1, 2, 3);
Vector3D vector2 = new Vector3D(4, 5, 6);
Vector3D vector3 = new Vector3D(7, 8, 9);

Vector3D largestVector = Vector3D.FindLargest(new List<Vector3D> { vector1, vector2, vector3 });
Console.WriteLine($"The largest vector is: {largestVector}");
```

## License

This project is licensed under the MIT License. See the LICENSE file for more details.