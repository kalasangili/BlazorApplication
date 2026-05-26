
let dotNetHelper;

window.ConfirmMessage = function (message) {
    return confirm(message);
}

window.AddTwoNumber = function (a,b) {
    return a + b;
}

function AlertMessageShown() {
    alert("This is a Alert Message from site.js");
}

function AlertClickJSMethod() {
    DotNet.invokeMethodAsync("BlazorApp1", "AlertMethod").then(result => {
        alert(result);
    });
}

window.AddJs = function (a,b) {
    DotNet.invokeMethodAsync("BlazorApp1", "AddCsharp", a, b).then(result => {
        console.log(result);
    })
}

window.SetRef = function (helper) {
    dotNetHelper = helper
}

window.InstanceMethodforAlert = function () {
    dotNetHelper.invokeMethodAsync("AlertInstance").then(result => {
        alert(result);
    });
} 