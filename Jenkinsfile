pipeline {
    agent { docker { image 'mcr.microsoft.com/dotnet/core/sdk'}}

    stages {
        stage('Build and Test') {
        steps {
               dir("timetrackerbackend"){
                sh 'pwd'
                sh 'ls'
                sh 'dotnet build'
              }
            }
        }

    }
}