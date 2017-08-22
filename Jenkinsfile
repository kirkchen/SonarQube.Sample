node {
    def nuget = "C:\\Tools\\nuget\\nuget.exe"
	def msbuildHome = tool name: 'Default', type: 'msbuild'
    def msbuild =  "\"${msbuildHome}\\MSBuild.exe\""
	def sonarqubeScannerHome = tool name: 'SonarQubeScannerMsbuild', type: 'hudson.plugins.sonar.MsBuildSQRunnerInstallation'
	def sonarqubeScanner = "\"${sonarqubeScannerHome}\\MSBuild.SonarQube.Runner.exe\""

	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat "${nuget} restore SonarQube.Sample.sln"
		bat "${sonarqubeScanner} /k:test /n:test /v:1.0.${BUILD_NUMBER} begin"
		bat "${msbuild}"
		bat "${sonarqubeScanner} end"
}