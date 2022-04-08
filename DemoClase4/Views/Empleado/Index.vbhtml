@ModelType IEnumerable(Of DemoClase4.Empleado)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")

    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.NroDocumento)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Nombre)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Apellido)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Direccion)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.FechaNacimiento)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Email)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Salario)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.NroDocumento)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Nombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Apellido)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Direccion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.FechaNacimiento)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Email)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Salario)
            </td>
            <td>
                @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
