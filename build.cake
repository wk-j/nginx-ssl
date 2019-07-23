#addin "wk.StartProcess"

using PS = StartProcess.Processor;


Task("Publish-Web").Does(() => {
    var name = "MyWeb";
    var project = $"src/{name}/{name}.csproj";
    DotNetCorePublish(project, new DotNetCorePublishSettings {
        OutputDirectory = ".publish/MyWeb"
    });
});

Task("Publish-Web2").Does(() => {
    var name = "MyWeb2";
    var project = $"src/{name}/{name}.csproj";

    DotNetCorePublish(project, new DotNetCorePublishSettings {
        OutputDirectory = ".publish/MyWeb2"
    });
});

Task("Start-Docker")
    .IsDependentOn("Publish-Web")
    .IsDependentOn("Publish-Web2")
    .Does(() => {

        PS.StartProcess("docker-compose down");
        PS.StartProcess("docker-compose build");
        PS.StartProcess("docker-compose up");
    });

var target = Argument("target", "default");
RunTarget(target);