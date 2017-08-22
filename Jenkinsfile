node {
    def nuget = "C:\\Tools\\nuget\\nuget.exe"
	def msbuildHome = tool name: 'Default', type: 'msbuild'
    def msbuild =  "\"${msbuildHome}\\MSBuild.exe\""
	def sonarqubeScannerHome = tool name: 'SonarQubeScannerMsbuild', type: 'hudson.plugins.sonar.MsBuildSQRunnerInstallation'
	def sonarqubeScanner = "\"${sonarqubeScannerHome}\\MSBuild.SonarQube.Runner.exe\""
	def mstest = "\"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Common7\\IDE\\MSTest.exe\""
	def vstest = "\"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Common7\\IDE\\CommonExtensions\\Microsoft\\TestWindow\\vstest.console.exe\""
	def codeCoverage = "\"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Team Tools\\Dynamic Code Coverage Tools\\CodeCoverage.exe\""

	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat "${nuget} restore SonarQube.Sample.sln"
		bat "${sonarqubeScanner} /k:test /n:test /v:1.0.${BUILD_NUMBER} /d:sonar.cs.vscoveragexml.reportsPaths=VisualStudio.coveragexml /d:sonar.cs.vstest.reportsPaths=MSTestResults.trx begin"
		bat "${msbuild}"
		bat "${mstest} /testcontainer:\"SonarQube.Sample.Test\\bin\\Debug\\SonarQube.Sample.Test.dll\" /resultsfile:MSTestResults.trx"
		bat "${codeCoverage} collect /output:VisualStudio.coverage ${vstest} \"SonarQube.Sample.Test\\bin\\Debug\\SonarQube.Sample.Test.dll\""
		bat "${codeCoverage} analyze /output:VisualStudio.coveragexml VisualStudio.coverage"
		bat "${sonarqubeScanner} end"
}