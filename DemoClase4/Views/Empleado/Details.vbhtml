@ModelType DemoClase4.Empleado

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <div>
        <h4>Empleado</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.NroDocumento)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.NroDocumento)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Nombre)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Nombre)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Apellido)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Apellido)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Direccion)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Direccion)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.FechaNacimiento)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.FechaNacimiento)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Email)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Email)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Salario)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Salario)
            </dd>
    
        </dl>
    </div>
    <p>
        @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
