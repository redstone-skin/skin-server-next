module.exports = {
  apps : [{
    name: 'frontend',
    script: '/app/frontend/index.js',
    watch: false,
    out_file: '/logs/front.out.log'
    
  }, {
    name: 'backend',
    script: '/app/backend/SkinServerNext',
    watch: false,
    out_file: '/logs/front.out.log'
  }],
  deploy : {
    production : {
      user : 'SSH_USERNAME',
      host : 'SSH_HOSTMACHINE',
      ref  : 'origin/master',
      repo : 'GIT_REPOSITORY',
      path : 'DESTINATION_PATH',
      'pre-deploy-local': '',
      'post-deploy' : 'npm install && pm2 reload ecosystem.config.js --env production',
      'pre-setup': ''
    }
  }
};
