func @_FlowerApp.Program.Main$string$$$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Program.cs" :14 :8) {
^entry (%_args : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Program.cs" :14 :32)
cbde.store %_args, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Program.cs" :14 :32)
br ^0

^0: // SimpleBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: BuildWebHost
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Program.cs" :25 :25) // Not a variable of known type: args
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Program.cs" :25 :12) // BuildWebHost(args) (InvocationExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Program.cs" :25 :12) // BuildWebHost(args).Run() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
