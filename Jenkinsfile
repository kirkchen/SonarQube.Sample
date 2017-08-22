node {
    def nuget = "C:\\Tools\\nuget\\nuget.exe"
    def msbuild =  "\"${tool name: 'Default', type: 'msbuild'}\\MSBuild.exe\""

	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat "${nuget} restore SonarQube.Sample.sln"
		bat "${msbuild}"
}