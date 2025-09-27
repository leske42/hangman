all:
	dotnet build playground && dotnet run --project playground

fclean:
	rm -rf playground/bin playground/obj 