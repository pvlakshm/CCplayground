.\MyApp\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user -target:".\MyApp\packages\xunit.runner.console.2.4.0\tools\net452\xunit.console.x86.exe" -targetargs:".\MyApp\AddTests\bin\Debug\AddTests.dll -noshadow" -output:".\coverage1.xml" -filter:"+[*Op]* -[*Tests*]*

.\MyApp\packages\Codecov.1.0.3\tools\codecov.exe -f .\coverage1.xml -t 92689bfe-74fc-417e-b4a0-bf231a0f901b


.\MyApp\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user -target:".\MyApp\packages\xunit.runner.console.2.4.0\tools\net452\xunit.console.x86.exe" -targetargs:".\MyApp\SubTests\bin\Debug\SubTests.dll -noshadow" -output:".\coverage2.xml" -filter:"+[*Op]* -[*Tests*]*

.\MyApp\packages\Codecov.1.0.3\tools\codecov.exe -f .\coverage2.xml -t 92689bfe-74fc-417e-b4a0-bf231a0f901b


.\MyApp\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user -target:".\MyApp\packages\xunit.runner.console.2.4.0\tools\net452\xunit.console.x86.exe" -targetargs:".\MyApp\MultTests\bin\Debug\MultTests.dll -noshadow" -output:".\coverage3.xml" -filter:"+[*Op]* -[*Tests*]*

.\MyApp\packages\Codecov.1.0.3\tools\codecov.exe -f .\coverage3.xml -t 92689bfe-74fc-417e-b4a0-bf231a0f901b


.\MyApp\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user -target:".\MyApp\packages\xunit.runner.console.2.4.0\tools\net452\xunit.console.x86.exe" -targetargs:".\MyApp\DivTests\bin\Debug\DivTests.dll -noshadow" -output:".\coverage4.xml" -filter:"+[*Op]* -[*Tests*]*

.\MyApp\packages\Codecov.1.0.3\tools\codecov.exe -f .\coverage4.xml -t 92689bfe-74fc-417e-b4a0-bf231a0f901b