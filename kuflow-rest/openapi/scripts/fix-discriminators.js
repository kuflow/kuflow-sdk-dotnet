#!/usr/bin/env node

const fs = require('fs')
const path = require('path')

function applyWorkaround() {

  {
    // Authentication.cs
    const file = `${process.cwd()}/../src-generated/Models/Authentication.cs`

    const fileData = fs.readFileSync(file)
    let fileAsStr = fileData.toString('utf8')

    fileAsStr = fileAsStr.replace(/ObjectType = new AuditedObjectType\("Authentication"\);/, 'ObjectType = AuditedObjectType.Authentication;')

    fs.writeFileSync(file, fileAsStr, 'utf8')
  }

  {
    // Process.cs
    const file = `${process.cwd()}/../src-generated/Models/Process.cs`

    const fileData = fs.readFileSync(file)
    let fileAsStr = fileData.toString('utf8')

    fileAsStr = fileAsStr.replace(/ObjectType = new AuditedObjectType\("Process"\);/, 'ObjectType = AuditedObjectType.Process;')

    fs.writeFileSync(file, fileAsStr, 'utf8')
  }

  {
    // Task.cs
    const file = `${process.cwd()}/../src-generated/Models/Task.cs`

    const fileData = fs.readFileSync(file)
    let fileAsStr = fileData.toString('utf8')

    fileAsStr = fileAsStr.replace(/ObjectType = new AuditedObjectType\("Task"\);/, 'ObjectType = AuditedObjectType.Task;')

    fs.writeFileSync(file, fileAsStr, 'utf8')
  }

  {
    // KuFlowRestModelFactory.cs
    const file = `${process.cwd()}/../src-generated/KuFlowRestModelFactory.cs`

    const fileData = fs.readFileSync(file)
    let fileAsStr = fileData.toString('utf8')

    fileAsStr = fileAsStr.replace(/new AuditedObjectType\("Authentication"\)/, 'AuditedObjectType.Authentication')

    fs.writeFileSync(file, fileAsStr, 'utf8')

    const fileNew = `${process.cwd()}/../src-generated/Models/KuFlowRestModelFactory.cs`
    fs.renameSync(file, fileNew)
  }
}

applyWorkaround()
