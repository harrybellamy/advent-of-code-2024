number=$1
lib_proj=Day${number}
dotnet new classlib -o Day${number}
dotnet add ${lib_proj}/${lib_proj}.csproj reference Common/Common.csproj

test_proj=Day${number}Tests
dotnet new xunit -o Day${number}Tests

dotnet add ${test_proj}/${test_proj}.csproj reference ${lib_proj}/${lib_proj}.csproj

solution_path=AdventOfCode2024.sln
solution_folder=Day${number}
dotnet sln ${solution_path} add ${lib_proj}/${lib_proj}.csproj --solution-folder ${solution_folder}
dotnet sln ${solution_path} add ${test_proj}/${test_proj}.csproj --solution-folder ${solution_folder}
read -p "Press any key to continue" x