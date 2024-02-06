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
}

applyWorkaround()
