node {
    def nuget = "C:\\Tools\\nuget\\nuget.exe"

	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat '${nuget} restore SonarQube.Sample.sln'
		bat "\"${tool name: 'Default', type: 'msbuild'}\""
}