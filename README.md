## Código base para completar el curso de prueba unitarias en .NET y C# con xUnit
Debe descargar el codigo y usar el branch master o 0

* Comandos para instalar Coverlet

```
> dotnet tool install --global coverlet.console --version 6.0.0

```
* Comandos para utilizarlo
```
> dotnet test /p:CollectCoverage=true
> dotnet test /p:CollectCoverage=true /p:Include="[*]StringManipulation"  -- Incluir solo los relaciondados al namespace

> dotnet test /p:CollectCoverage=true /p:ExcludeByAttribute="ExcludeFromCodeCoverage"  -- Excluir usando la anotacion [ExcludeFromCodeCoverage]

> dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura

> reportgenerator "-reports:coverage.cobertura.xml" "-targetdir:coverage-report" -reporttypes:html; -- genera reporte, debe instalar ReportGenerator y estar en el proyecto Test
```

