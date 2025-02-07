@*
For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
*@
@{
}
@model Book



<div class="card m-1 p-1">
    <h4>
@Model.Title
<span class="badge roundedcard-header-pills bg-primary text-white float-end"><small>$@Model.Price</small></span>
</h4>
<ul>
<li>Author: @Model.Author</li>
<li>Publisher: @Model.Publisher</li>
<li>ISBN: @Model.Isbn</li>
<li>Category: @Model.Category</li>
<li>Classification: @Model.Classification</li>
<li>Page Count: @Model.PageCount</li>
</ul>
</div>