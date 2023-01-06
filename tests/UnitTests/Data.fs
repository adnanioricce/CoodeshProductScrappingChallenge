namespace Tests
module Data = 
    let productPages = """
        <ul id="pages" class="pagination"><li class="unavailable">Pages:</li><li class="current"><a href="">1</a></li><li><a href="/2">2</a></li><li><a href="/3">3</a></li><li><a href="/4">4</a></li><li class="unavailable">…</li><li><a href="/27331">27331</a></li><li><a href="/27332">27332</a></li><li><a href="/27333">27333</a></li><li><a href="/2" rel="next$nofollow">Next</a></li><li class="unavailable">(100 products per page)</li></ul>
    """
    let allProductsDivStr = """
        <div id="search_results" style="clear:left;">
        <ul class="products">
    
    
    
      
        <li>
        
          <a href="/product/3017620422003/nutella-ferrero" title="Nutella - Ferrero -&nbsp;400┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/301/762/042/2003/front_en.430.100.jpg" srcset="https://images.openfoodfacts.org/images/products/301/762/042/2003/front_en.430.200.jpg 2x" alt="Nutella - Product" loading="lazy" width="100" height="68">
</div>
            <span>Nutella - Ferrero -&nbsp;400┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3274080005003/eaux-de-sources-cristaline" title="Eaux de sources - Cristaline -&nbsp;1,5┬ál">
          
            <div><img src="https://images.openfoodfacts.org/images/products/327/408/000/5003/front_en.797.100.jpg" srcset="https://images.openfoodfacts.org/images/products/327/408/000/5003/front_en.797.200.jpg 2x" alt="Eau de source - Product" loading="lazy" width="30" height="100">
</div>
            <span>Eaux de sources - Cristaline -&nbsp;1,5┬ál</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7622210449283/prince-lu" title="Prince - Lu -&nbsp;300┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/762/221/044/9283/front_en.427.100.jpg" srcset="https://images.openfoodfacts.org/images/products/762/221/044/9283/front_en.427.200.jpg 2x" alt="Prince - Product" loading="lazy" width="34" height="100">
</div>
            <span>Prince - Lu -&nbsp;300┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5449000000996/coca-cola" title="Coca-Cola -&nbsp;330ml">
          
            <div><img src="https://images.openfoodfacts.org/images/products/544/900/000/0996/front_en.676.100.jpg" srcset="https://images.openfoodfacts.org/images/products/544/900/000/0996/front_en.676.200.jpg 2x" alt="Coca-Cola - Product" loading="lazy" width="69" height="100">
</div>
            <span>Coca-Cola -&nbsp;330ml</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3017620425035/nutella-ferrero" title="Nutella - Ferrero -&nbsp;1┬ákg">
          
            <div><img src="https://images.openfoodfacts.org/images/products/301/762/042/5035/front_en.397.100.jpg" srcset="https://images.openfoodfacts.org/images/products/301/762/042/5035/front_en.397.200.jpg 2x" alt="Nutella - Product" loading="lazy" width="67" height="100">
</div>
            <span>Nutella - Ferrero -&nbsp;1┬ákg</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3175680011480/sesame-gerble" title="S├®same - Gerbl├® -&nbsp;230g">
          
            <div><img src="https://images.openfoodfacts.org/images/products/317/568/001/1480/front_en.221.100.jpg" srcset="https://images.openfoodfacts.org/images/products/317/568/001/1480/front_en.221.200.jpg 2x" alt="S├®same - Product" loading="lazy" width="100" height="48">
</div>
            <span>S├®same - Gerbl├® -&nbsp;230g</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5449000131805/coca-cola-zero" title="Coca Cola Zero -&nbsp;330ml">
          
            <div><img src="https://images.openfoodfacts.org/images/products/544/900/013/1805/front_en.490.100.jpg" srcset="https://images.openfoodfacts.org/images/products/544/900/013/1805/front_en.490.200.jpg 2x" alt="Coca Cola Zero - Product" loading="lazy" width="53" height="100">
</div>
            <span>Coca Cola Zero -&nbsp;330ml</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3046920022651/chocolate-excellence-lindt" title="Chocolate Excellence - Lindt -&nbsp;100┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/304/692/002/2651/front.7.100.jpg" srcset="https://images.openfoodfacts.org/images/products/304/692/002/2651/front.7.200.jpg 2x" alt="Chocolate Excellence - Product" loading="lazy" width="50" height="100">
</div>
            <span>Chocolate Excellence - Lindt -&nbsp;100┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/8000500310427/nutella-biscuits" title="Nutella biscuits -&nbsp;304┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/800/050/031/0427/front_en.169.100.jpg" srcset="https://images.openfoodfacts.org/images/products/800/050/031/0427/front_en.169.200.jpg 2x" alt="Nutella Biscuits - Product" loading="lazy" width="75" height="100">
</div>
            <span>Nutella biscuits -&nbsp;304┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3168930010265/cruesli-melange-de-noix-quaker" title="Cruesli M├®lange De Noix - Quaker -&nbsp;450┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/316/893/001/0265/front_en.206.100.jpg" srcset="https://images.openfoodfacts.org/images/products/316/893/001/0265/front_en.206.200.jpg 2x" alt="Cruesli m├®lange de noix - Product" loading="lazy" width="82" height="100">
</div>
            <span>Cruesli M├®lange De Noix - Quaker -&nbsp;450┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5400141431537/nems-au-porc-avec-sauce-tomate-pimentee-boni" title="Nems Au Porc - avec sauce tomate piment├®e - Boni - 240┬ág (8┬áx&nbsp;30┬ág)">
          
            <div><img src="https://images.openfoodfacts.org/images/products/540/014/143/1537/front_fr.18.100.jpg" srcset="https://images.openfoodfacts.org/images/products/540/014/143/1537/front_fr.18.200.jpg 2x" alt="Nems Au Porc - avec sauce tomate piment├®e - Product" loading="lazy" width="77" height="100">
</div>
            <span>Nems Au Porc - avec sauce tomate piment├®e - Boni - 240┬ág (8┬áx&nbsp;30┬ág)</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5900649063785/nycoffee" title="NYcoffee -  - 204┬ág, 17┬ág x&nbsp;12">
          
            <div><img src="https://images.openfoodfacts.org/images/products/590/064/906/3785/front_en.4.100.jpg" srcset="https://images.openfoodfacts.org/images/products/590/064/906/3785/front_en.4.200.jpg 2x" alt="NYcoffee - Product" loading="lazy" width="72" height="100">
</div>
            <span>NYcoffee -  - 204┬ág, 17┬ág x&nbsp;12</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5000128677127/8-mini-brownie-bites-coop" title="8 mini brownie bites -&nbsp;Coop">
          
            <div><img src="https://images.openfoodfacts.org/images/products/500/012/867/7127/front_en.3.100.jpg" srcset="https://images.openfoodfacts.org/images/products/500/012/867/7127/front_en.3.200.jpg 2x" alt="8 mini brownie bites - Product" loading="lazy" width="54" height="100">
</div>
            <span>8 mini brownie bites -&nbsp;Coop</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/8719324347129/broccoli-generic" title="Broccoli - generic -&nbsp;1┬ácrop">
          
            <div><img src="https://static.openfoodfacts.org/images/svg/product-silhouette.svg" style="width:100;height:100">

</div>
            <span>Broccoli - generic -&nbsp;1┬ácrop</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3229820129488/muesli-raisin-figue-abricot-bjorg" title="Muesli Raisin, Figue, Abricot - Bjorg -&nbsp;375┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/982/012/9488/front_fr.194.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/982/012/9488/front_fr.194.200.jpg 2x" alt="Muesli Raisin, Figue, Abricot - Product" loading="lazy" width="66" height="100">
</div>
            <span>Muesli Raisin, Figue, Abricot - Bjorg -&nbsp;375┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/8001505005592/nocciolata-pate-a-tartiner-au-cacao-et-noisettes-rigoni-di-asiago" title="Nocciolata P├óte ├á tartiner au cacao et noisettes - Rigoni di Asiago -&nbsp;270┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/800/150/500/5592/front_fr.113.100.jpg" srcset="https://images.openfoodfacts.org/images/products/800/150/500/5592/front_fr.113.200.jpg 2x" alt="Nocciolata P├óte ├á tartiner au cacao et noisettes - Product" loading="lazy" width="60" height="100">
</div>
            <span>Nocciolata P├óte ├á tartiner au cacao et noisettes - Rigoni di Asiago -&nbsp;270┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3760020507350/pur-beurre-de-cacahuete-jardin-bio" title="Pur beurre de cacahu├¿te - Jardin Bio -&nbsp;350┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/376/002/050/7350/front_en.257.100.jpg" srcset="https://images.openfoodfacts.org/images/products/376/002/050/7350/front_en.257.200.jpg 2x" alt="Pur beurre de cacahu├¿te - Product" loading="lazy" width="57" height="100">
</div>
            <span>Pur beurre de cacahu├¿te - Jardin Bio -&nbsp;350┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3229820100234/fourres-chocolat-noir-bio-bjorg" title="Fourr├®s Chocolat noir BIO - bjorg -&nbsp;225┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/982/010/0234/front_fr.159.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/982/010/0234/front_fr.159.200.jpg 2x" alt="Fourr├®s Chocolat noir BIO - Product" loading="lazy" width="100" height="36">
</div>
            <span>Fourr├®s Chocolat noir BIO - bjorg -&nbsp;225┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3228857000166/100-mie-complet-harrys" title="100% mie complet - Harrys -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/885/700/0166/front_fr.1750.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/885/700/0166/front_fr.1750.200.jpg 2x" alt="100% mie complet - Product" loading="lazy" width="35" height="100">
</div>
            <span>100% mie complet - Harrys -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7613034626844/cereales-chocapic-nestle" title="C├®r├®ales chocapic - Nestl├® -&nbsp;430┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/761/303/462/6844/front_en.268.100.jpg" srcset="https://images.openfoodfacts.org/images/products/761/303/462/6844/front_en.268.200.jpg 2x" alt="NESTLE CHOCAPIC C├®r├®ales 430g - Product" loading="lazy" width="71" height="100">
</div>
            <span>C├®r├®ales chocapic - Nestl├® -&nbsp;430┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3268840001008/cristaline-eau-de-source" title="Cristaline Eau de source -&nbsp;50┬ácl">
          
            <div><img src="https://images.openfoodfacts.org/images/products/326/884/000/1008/front_fr.377.100.jpg" srcset="https://images.openfoodfacts.org/images/products/326/884/000/1008/front_fr.377.200.jpg 2x" alt="Cristaline Eau de source - Product" loading="lazy" width="37" height="100">
</div>
            <span>Cristaline Eau de source -&nbsp;50┬ácl</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7300400481588/tartine-croustillante-fibres-wasa" title="Tartine croustillante FIBRES - Wasa -&nbsp;230┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/730/040/048/1588/front_fr.178.100.jpg" srcset="https://images.openfoodfacts.org/images/products/730/040/048/1588/front_fr.178.200.jpg 2x" alt="Tartine croustillante FIBRES - Product" loading="lazy" width="100" height="82">
</div>
            <span>Tartine croustillante FIBRES - Wasa -&nbsp;230┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3175681851849/pomme-noisette-gerble" title="Pomme noisette - Gerbl├® - 230┬ág (16┬áx&nbsp;14.4┬ág)">
          
            <div><img src="https://images.openfoodfacts.org/images/products/317/568/185/1849/front_fr.179.100.jpg" srcset="https://images.openfoodfacts.org/images/products/317/568/185/1849/front_fr.179.200.jpg 2x" alt="Pomme noisette - Product" loading="lazy" width="100" height="39">
</div>
            <span>Pomme noisette - Gerbl├® - 230┬ág (16┬áx&nbsp;14.4┬ág)</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3046920022606/excellence-85-cacao-chocolat-noir-puissant-lindt-lindt" title="Excellence 85% Cacao Chocolat Noir Puissant Lindt % Lindt -&nbsp;100┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/304/692/002/2606/front_en.102.100.jpg" srcset="https://images.openfoodfacts.org/images/products/304/692/002/2606/front_en.102.200.jpg 2x" alt="85% Potente Black Cacao - Product" loading="lazy" width="75" height="100">
</div>
            <span>Excellence 85% Cacao Chocolat Noir Puissant Lindt % Lindt -&nbsp;100┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5010477348678/special-muesli-30-fruits-noix-jordans" title="Special Muesli 30% fruits &amp; noix - Jordans -&nbsp;750┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/501/047/734/8678/front_fr.211.100.jpg" srcset="https://images.openfoodfacts.org/images/products/501/047/734/8678/front_fr.211.200.jpg 2x" alt="Special Muesli 30% fruits &amp; noix - Product" loading="lazy" width="72" height="100">
</div>
            <span>Special Muesli 30% fruits &amp; noix - Jordans -&nbsp;750┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5449000214911/coca-cola-gout-original" title="Coca-cola go├╗t original -&nbsp;330┬áml">
          
            <div><img src="https://images.openfoodfacts.org/images/products/544/900/021/4911/front_en.119.100.jpg" srcset="https://images.openfoodfacts.org/images/products/544/900/021/4911/front_en.119.200.jpg 2x" alt="Coca-cola go├╗t original - Product" loading="lazy" width="41" height="100">
</div>
            <span>Coca-cola go├╗t original -&nbsp;330┬áml</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3057640257773/volvic" title="Volvic -&nbsp;1,5┬áL">
          
            <div><img src="https://images.openfoodfacts.org/images/products/305/764/025/7773/front_fr.265.100.jpg" srcset="https://images.openfoodfacts.org/images/products/305/764/025/7773/front_fr.265.200.jpg 2x" alt="Volvic - Product" loading="lazy" width="31" height="100">
</div>
            <span>Volvic -&nbsp;1,5┬áL</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7622210601988/granola-lu" title="Granola - LU - 200┬ág&nbsp;e">
          
            <div><img src="https://images.openfoodfacts.org/images/products/762/221/060/1988/front_en.168.100.jpg" srcset="https://images.openfoodfacts.org/images/products/762/221/060/1988/front_en.168.200.jpg 2x" alt="Granola - L'original - chocolat au lait - Product" loading="lazy" width="100" height="31">
</div>
            <span>Granola - LU - 200┬ág&nbsp;e</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3256540000698/pains-au-lait-pasquier" title="Pains au lait - Pasquier -&nbsp;350┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/325/654/000/0698/front_fr.126.100.jpg" srcset="https://images.openfoodfacts.org/images/products/325/654/000/0698/front_fr.126.200.jpg 2x" alt="Pains au lait - Product" loading="lazy" width="46" height="100">
</div>
            <span>Pains au lait - Pasquier -&nbsp;350┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5449000214799/coca-cola-zero" title="Coca Cola Zero -&nbsp;330┬áml">
          
            <div><img src="https://images.openfoodfacts.org/images/products/544/900/021/4799/front_en.163.100.jpg" srcset="https://images.openfoodfacts.org/images/products/544/900/021/4799/front_en.163.200.jpg 2x" alt="Coca Cola zero - Product" loading="lazy" width="75" height="100">
</div>
            <span>Coca Cola Zero -&nbsp;330┬áml</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3229820019307/bjorg" title="Bjorg -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/982/001/9307/front_en.195.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/982/001/9307/front_en.195.200.jpg 2x" alt=" - Product" loading="lazy" width="56" height="100">
</div>
            <span>Bjorg -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3033710065967/nesquik-cacao-nestle" title="NESQUIK Cacao - Nestl├® -&nbsp;1┬ákg">
          
            <div><img src="https://images.openfoodfacts.org/images/products/303/371/006/5967/front_fr.430.100.jpg" srcset="https://images.openfoodfacts.org/images/products/303/371/006/5967/front_fr.430.200.jpg 2x" alt="NESQUIK Cacao - Product" loading="lazy" width="61" height="100">
</div>
            <span>NESQUIK Cacao - Nestl├® -&nbsp;1┬ákg</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3392460480827/biscottes-heudebert" title="Biscottes heudebert - 300┬ág&nbsp;e">
          
            <div><img src="https://images.openfoodfacts.org/images/products/339/246/048/0827/front_en.72.100.jpg" srcset="https://images.openfoodfacts.org/images/products/339/246/048/0827/front_en.72.200.jpg 2x" alt="Biscottes 6 C├®r├®ales - Product" loading="lazy" width="96" height="100">
</div>
            <span>Biscottes heudebert - 300┬ág&nbsp;e</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/8002270014901/san-pellegrino" title="San Pellegrino -&nbsp;1┬áL">
          
            <div><img src="https://images.openfoodfacts.org/images/products/800/227/001/4901/front_fr.202.100.jpg" srcset="https://images.openfoodfacts.org/images/products/800/227/001/4901/front_fr.202.200.jpg 2x" alt="San Pellegrino - Product" loading="lazy" width="28" height="100">
</div>
            <span>San Pellegrino -&nbsp;1┬áL</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7613035040823/chocolat-noir-pour-preparation-patissiere-nestle" title="Chocolat Noir Pour Pr├®paration P├ótissi├¿re - Nestl├® - 205┬ág&nbsp;e">
          
            <div><img src="https://images.openfoodfacts.org/images/products/761/303/504/0823/front_en.190.100.jpg" srcset="https://images.openfoodfacts.org/images/products/761/303/504/0823/front_en.190.200.jpg 2x" alt="Chocolat Noir Pour Pr├®paration P├ótissi├¿re - Product" loading="lazy" width="45" height="100">
</div>
            <span>Chocolat Noir Pour Pr├®paration P├ótissi├¿re - Nestl├® - 205┬ág&nbsp;e</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3029330022428/pain-de-mie-complet-sans-sucres-ajoutes-jacquet" title="Pain de mie complet sans sucres ajout├®s - Jacquet -&nbsp;550┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/302/933/002/2428/front_en.118.100.jpg" srcset="https://images.openfoodfacts.org/images/products/302/933/002/2428/front_en.118.200.jpg 2x" alt="Pain de mie complet sans sucres ajout├®s - Product" loading="lazy" width="77" height="100">
</div>
            <span>Pain de mie complet sans sucres ajout├®s - Jacquet -&nbsp;550┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3155250358788/primevere" title="Primev├¿re -&nbsp;250┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/315/525/035/8788/front.3.100.jpg" srcset="https://images.openfoodfacts.org/images/products/315/525/035/8788/front.3.200.jpg 2x" alt=" - Product" loading="lazy" width="100" height="68">
</div>
            <span>Primev├¿re -&nbsp;250┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3502110009449/tpp-orange-sans-pulpe-pet-1l-tropicana" title="Tpp orange sans pulpe pet 1l - Tropicana -&nbsp;1000┬áml">
          
            <div><img src="https://static.openfoodfacts.org/images/svg/product-silhouette.svg" style="width:100;height:100">

</div>
            <span>Tpp orange sans pulpe pet 1l - Tropicana -&nbsp;1000┬áml</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7613035974685/eau-minerale-naturelle-hepar" title="Eau min├®rale naturelle - H├®par -&nbsp;1┬áL">
          
            <div><img src="https://images.openfoodfacts.org/images/products/761/303/597/4685/front_fr.237.100.jpg" srcset="https://images.openfoodfacts.org/images/products/761/303/597/4685/front_fr.237.200.jpg 2x" alt="Eau min├®rale naturelle - Product" loading="lazy" width="28" height="100">
</div>
            <span>Eau min├®rale naturelle - H├®par -&nbsp;1┬áL</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7622210713780/belvita-petit-dejeuner-chocolat-lu" title="Belvita Petit D├®jeuner Chocolat - LU -&nbsp;400┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/762/221/071/3780/front_fr.189.100.jpg" srcset="https://images.openfoodfacts.org/images/products/762/221/071/3780/front_fr.189.200.jpg 2x" alt="Belvita Petit D├®jeuner Chocolat - Product" loading="lazy" width="64" height="100">
</div>
            <span>Belvita Petit D├®jeuner Chocolat - LU -&nbsp;400┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/8001505005707/nocciolata-rigoni-di-asiago" title="Nocciolata - Rigoni di Asiago -&nbsp;700┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/800/150/500/5707/front_fr.152.100.jpg" srcset="https://images.openfoodfacts.org/images/products/800/150/500/5707/front_fr.152.200.jpg 2x" alt="Nocciolata - Product" loading="lazy" width="75" height="100">
</div>
            <span>Nocciolata - Rigoni di Asiago -&nbsp;700┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3175680011534/gerble" title="Gerbl├® -&nbsp;230┬ág">
          
            <div><img src="https://static.openfoodfacts.org/images/svg/product-silhouette.svg" style="width:100;height:100">

</div>
            <span>Gerbl├® -&nbsp;230┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3760049790214/pain-de-mie-bio-la-boulangere-bio" title="Pain De Mie Bio - La Boulang├¿re Bio -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/376/004/979/0214/front_en.182.100.jpg" srcset="https://images.openfoodfacts.org/images/products/376/004/979/0214/front_en.182.200.jpg 2x" alt="Pain De Mie Bio - Product" loading="lazy" width="74" height="100">
</div>
            <span>Pain De Mie Bio - La Boulang├¿re Bio -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5449000133328/coca-cola-1-litre-zero-coca-cola-zero" title="Coca cola 1 litre zero - Coca-Cola zero -&nbsp;1L">
          
            <div><img src="https://images.openfoodfacts.org/images/products/544/900/013/3328/front_en.185.100.jpg" srcset="https://images.openfoodfacts.org/images/products/544/900/013/3328/front_en.185.200.jpg 2x" alt="Coca Z├®ro - Product" loading="lazy" width="100" height="20">
</div>
            <span>Coca cola 1 litre zero - Coca-Cola zero -&nbsp;1L</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3228857000852/pain-100-mie-nature-pt-harrys" title="Pain 100% mie nature PT - Harrys -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/885/700/0852/front_en.160.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/885/700/0852/front_en.160.200.jpg 2x" alt="Pain 100% mie nature PT - Product" loading="lazy" width="35" height="100">
</div>
            <span>Pain 100% mie nature PT - Harrys -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3046920029759/dark-chocolate-90-cocoa-lindt" title="Dark Chocolate 90% cocoa - Lindt -&nbsp;100┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/304/692/002/9759/front_en.254.100.jpg" srcset="https://images.openfoodfacts.org/images/products/304/692/002/9759/front_en.254.200.jpg 2x" alt="Dark Chocolate 90% cocoa - Product" loading="lazy" width="47" height="100">
</div>
            <span>Dark Chocolate 90% cocoa - Lindt -&nbsp;100┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3168930009078/quaker-oats-flocons-d-avoine-complete" title="Quaker Oats Flocons d'avoine compl├¿te -&nbsp;550┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/316/893/000/9078/front_en.148.100.jpg" srcset="https://images.openfoodfacts.org/images/products/316/893/000/9078/front_en.148.200.jpg 2x" alt="Quaker Oats Flocons d'avoine compl├¿te - Product" loading="lazy" width="71" height="100">
</div>
            <span>Quaker Oats Flocons d'avoine compl├¿te -&nbsp;550┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/80135463/ferrero-nutella-chocolate-hazelnut-spread-christmas" title="Ferrero nutella chocolate hazelnut spread christmas -&nbsp;200┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/80135463/front_en.183.100.jpg" srcset="https://images.openfoodfacts.org/images/products/80135463/front_en.183.200.jpg 2x" alt="Ferrero nutella chocolate hazelnut spread christmas - Product" loading="lazy" width="81" height="100">
</div>
            <span>Ferrero nutella chocolate hazelnut spread christmas -&nbsp;200┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3159470000120/corn-flakes-kellogg-s" title="Corn flakes - Kellogg's -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/315/947/000/0120/front_en.147.100.jpg" srcset="https://images.openfoodfacts.org/images/products/315/947/000/0120/front_en.147.200.jpg 2x" alt="Corn flakes - Product" loading="lazy" width="69" height="100">
</div>
            <span>Corn flakes - Kellogg's -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3033490004521/yaourt-nature-le-nature-danone" title="Yaourt nature- Le Nature - Danone - 500┬ág (4 ├ù&nbsp;125┬ág)">
          
            <div><img src="https://images.openfoodfacts.org/images/products/303/349/000/4521/front_fr.93.100.jpg" srcset="https://images.openfoodfacts.org/images/products/303/349/000/4521/front_fr.93.200.jpg 2x" alt="Yaourt nature- Le Nature - Product" loading="lazy" width="100" height="66">
</div>
            <span>Yaourt nature- Le Nature - Danone - 500┬ág (4 ├ù&nbsp;125┬ág)</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3228857000906/harrys-pain-de-mie-american-sandwich-complet-600g" title="Harrys pain de mie american sandwich complet 600g -&nbsp;600┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/885/700/0906/front_fr.1324.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/885/700/0906/front_fr.1324.200.jpg 2x" alt="Harrys pain de mie american sandwich complet 600g - Product" loading="lazy" width="55" height="100">
</div>
            <span>Harrys pain de mie american sandwich complet 600g -&nbsp;600┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5410041001204/snacks-tuc-original-lu" title="Snacks, TUC Original - LU -&nbsp;100g">
          
            <div><img src="https://images.openfoodfacts.org/images/products/541/004/100/1204/front_en.299.100.jpg" srcset="https://images.openfoodfacts.org/images/products/541/004/100/1204/front_en.299.200.jpg 2x" alt="TUC Original - Product" loading="lazy" width="100" height="74">
</div>
            <span>Snacks, TUC Original - LU -&nbsp;100g</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7300400481595/tartine-croustillante-authentique-wasa" title="Tartine croustillante Authentique - Wasa -&nbsp;275┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/730/040/048/1595/front_fr.170.100.jpg" srcset="https://images.openfoodfacts.org/images/products/730/040/048/1595/front_fr.170.200.jpg 2x" alt="Tartine croustillante Authentique - Product" loading="lazy" width="100" height="70">
</div>
            <span>Tartine croustillante Authentique - Wasa -&nbsp;275┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3033710065066/nesquik-poudre-cacaotee-boite-250g-nestlenesquik" title="NESQUIK Poudre Cacaot├®e bo├«te 250g - Nestl├®Nesquik -&nbsp;250┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/303/371/006/5066/front_fr.328.100.jpg" srcset="https://images.openfoodfacts.org/images/products/303/371/006/5066/front_fr.328.200.jpg 2x" alt="NESQUIK Poudre Cacaot├®e bo├«te 250g - Product" loading="lazy" width="100" height="86">
</div>
            <span>NESQUIK Poudre Cacaot├®e bo├«te 250g - Nestl├®Nesquik -&nbsp;250┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3229820021027/bio-nutri-p-tit-nature-complet-bjorg" title="Bio Nutri  P'tit Nature Complet - Bjorg - 200┬ág&nbsp;(24┬ábiscuits)">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/982/002/1027/front_fr.162.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/982/002/1027/front_fr.162.200.jpg 2x" alt="Bio Nutri  P'tit Nature Complet - Product" loading="lazy" width="100" height="42">
</div>
            <span>Bio Nutri  P'tit Nature Complet - Bjorg - 200┬ág&nbsp;(24┬ábiscuits)</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3228857001231/brioche-tressee-a-la-main-sans-additifs-harrys" title="Brioche tress├®e ├á la main sans additifs - Harrys -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/885/700/1231/front_fr.72.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/885/700/1231/front_fr.72.200.jpg 2x" alt="Harrys brioche tressee nature au sucre perle sans additifs 500g - Product" loading="lazy" width="35" height="100">
</div>
            <span>Brioche tress├®e ├á la main sans additifs - Harrys -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5411188119098/natur-mit-kokosnuss-alpro" title="Natur mit Kokosnuss - Alpro -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/541/118/811/9098/front_de.102.100.jpg" srcset="https://images.openfoodfacts.org/images/products/541/118/811/9098/front_de.102.200.jpg 2x" alt="Natur mit Kokosnuss - Product" loading="lazy" width="63" height="100">
</div>
            <span>Natur mit Kokosnuss - Alpro -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5053990156009/chips-pringles-original" title="Chips Pringles Original - 175┬ág&nbsp;e">
          
            <div><img src="https://images.openfoodfacts.org/images/products/505/399/015/6009/front_fr.107.100.jpg" srcset="https://images.openfoodfacts.org/images/products/505/399/015/6009/front_fr.107.200.jpg 2x" alt="Chips Pringles Original - Product" loading="lazy" width="37" height="100">
</div>
            <span>Chips Pringles Original - 175┬ág&nbsp;e</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3045140105502/2-x-schokolade-alpenmilch-milka" title="2 x Schokolade - Alpenmilch - Milka -&nbsp;100g">
          
            <div><img src="https://images.openfoodfacts.org/images/products/304/514/010/5502/front_en.162.100.jpg" srcset="https://images.openfoodfacts.org/images/products/304/514/010/5502/front_en.162.200.jpg 2x" alt="2 x Schokolade - Alpenmilch - Product" loading="lazy" width="100" height="48">
</div>
            <span>2 x Schokolade - Alpenmilch - Milka -&nbsp;100g</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7613035989535/le-bon-paris-herta" title="Le bon paris - Herta - 140┬ág&nbsp;e">
          
            <div><img src="https://images.openfoodfacts.org/images/products/761/303/598/9535/front_fr.181.100.jpg" srcset="https://images.openfoodfacts.org/images/products/761/303/598/9535/front_fr.181.200.jpg 2x" alt="Le Bon Paris ├á l'├ëtouff├®e Sans Nitrite 4 Tranches - Product" loading="lazy" width="93" height="100">
</div>
            <span>Le bon paris - Herta - 140┬ág&nbsp;e</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3175680011442/biscuit-soja-orange-gerble" title="Biscuit soja orange - Gerbl├® -&nbsp;280┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/317/568/001/1442/front_en.142.100.jpg" srcset="https://images.openfoodfacts.org/images/products/317/568/001/1442/front_en.142.200.jpg 2x" alt="Biscuit soja orange - Product" loading="lazy" width="100" height="48">
</div>
            <span>Biscuit soja orange - Gerbl├® -&nbsp;280┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3033491454080/skyr-danone" title="SKYR - Danone -&nbsp;480┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/303/349/145/4080/front_fr.121.100.jpg" srcset="https://images.openfoodfacts.org/images/products/303/349/145/4080/front_fr.121.200.jpg 2x" alt="SKYR - Product" loading="lazy" width="100" height="77">
</div>
            <span>SKYR - Danone -&nbsp;480┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3175680015228/levure-de-biere-a-saupoudrer-gerble" title="Levure de bi├¿re ├á saupoudrer - Gerbl├® -&nbsp;150┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/317/568/001/5228/front_fr.201.100.jpg" srcset="https://images.openfoodfacts.org/images/products/317/568/001/5228/front_fr.201.200.jpg 2x" alt="Levure de bi├¿re ├á saupoudrer - Product" loading="lazy" width="75" height="100">
</div>
            <span>Levure de bi├¿re ├á saupoudrer - Gerbl├® -&nbsp;150┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3251490332080/biscuits-figue-et-son-gerble" title="Biscuits Figue et son - Gerbl├® -&nbsp;210┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/325/149/033/2080/front_fr.112.100.jpg" srcset="https://images.openfoodfacts.org/images/products/325/149/033/2080/front_fr.112.200.jpg 2x" alt="Biscuits Figue et son - Product" loading="lazy" width="100" height="37">
</div>
            <span>Biscuits Figue et son - Gerbl├® -&nbsp;210┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/8712100325953/dijon-senf-amoraunilever" title="Dijon-Senf - AmoraUnilever -&nbsp;440g">
          
            <div><img src="https://images.openfoodfacts.org/images/products/871/210/032/5953/front_en.192.100.jpg" srcset="https://images.openfoodfacts.org/images/products/871/210/032/5953/front_en.192.200.jpg 2x" alt="Moutarde de Dijon Fine &amp; Forte - Product" loading="lazy" width="48" height="100">
</div>
            <span>Dijon-Senf - AmoraUnilever -&nbsp;440g</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3229820787015/amande-sans-sucre-bjorg" title="Amande sans sucre - Bjorg -&nbsp;1┬ál">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/982/078/7015/front.16.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/982/078/7015/front.16.200.jpg 2x" alt="Amande sans sucre - Product" loading="lazy" width="51" height="100">
</div>
            <span>Amande sans sucre - Bjorg -&nbsp;1┬ál</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5010477348357/country-crisp-4-noix-jordans" title="Country Crisp 4 noix - Jordans -&nbsp;550┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/501/047/734/8357/front_fr.191.100.jpg" srcset="https://images.openfoodfacts.org/images/products/501/047/734/8357/front_fr.191.200.jpg 2x" alt="Country Crisp 4 noix - Product" loading="lazy" width="80" height="100">
</div>
            <span>Country Crisp 4 noix - Jordans -&nbsp;550┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3451790988677/le-beurre-tendre-doux-elle-vire" title="Le Beurre Tendre Doux - Elle &amp; Vire -&nbsp;250┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/345/179/098/8677/front.3.100.jpg" srcset="https://images.openfoodfacts.org/images/products/345/179/098/8677/front.3.200.jpg 2x" alt="Le Beurre Tendre Doux - Product" loading="lazy" width="100" height="56">
</div>
            <span>Le Beurre Tendre Doux - Elle &amp; Vire -&nbsp;250┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3033490004743/skyr-danone" title="Skyr - Danone -&nbsp;140┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/303/349/000/4743/front_fr.113.100.jpg" srcset="https://images.openfoodfacts.org/images/products/303/349/000/4743/front_fr.113.200.jpg 2x" alt="Skyr - Product" loading="lazy" width="93" height="100">
</div>
            <span>Skyr - Danone -&nbsp;140┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7622210713926/belvita-brut-5-cereales-completes-lu" title="Belvita Brut &amp; 5 c├®r├®ales compl├¿tes - Lu - 400┬ág , 8x&nbsp;4┬ábiscuits">
          
            <div><img src="https://images.openfoodfacts.org/images/products/762/221/071/3926/front_fr.155.100.jpg" srcset="https://images.openfoodfacts.org/images/products/762/221/071/3926/front_fr.155.200.jpg 2x" alt="Belvita Brut &amp; 5 c├®r├®ales compl├¿tes - Product" loading="lazy" width="75" height="100">
</div>
            <span>Belvita Brut &amp; 5 c├®r├®ales compl├¿tes - Lu - 400┬ág , 8x&nbsp;4┬ábiscuits</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/8715700407760/tomato-ketchup-bio-heinz" title="Tomato Ketchup BIO - Heinz -&nbsp;580┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/871/570/040/7760/front_en.141.100.jpg" srcset="https://images.openfoodfacts.org/images/products/871/570/040/7760/front_en.141.200.jpg 2x" alt="Tomato Ketchup BIO - Product" loading="lazy" width="45" height="100">
</div>
            <span>Tomato Ketchup BIO - Heinz -&nbsp;580┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7622210421968/veritable-petit-ecolier-chocolat-au-lait-lu" title="V├®ritable Petit ├ëcolier Chocolat au Lait - LU - 150┬ág (12x 12.5┬ág)&nbsp;e">
          
            <div><img src="https://images.openfoodfacts.org/images/products/762/221/042/1968/front_fr.102.100.jpg" srcset="https://images.openfoodfacts.org/images/products/762/221/042/1968/front_fr.102.200.jpg 2x" alt="V├®ritable Petit ├ëcolier Chocolat au Lait - Product" loading="lazy" width="100" height="36">
</div>
            <span>V├®ritable Petit ├ëcolier Chocolat au Lait - LU - 150┬ág (12x 12.5┬ág)&nbsp;e</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3023470001015/20-galettes-traditional-butter-biscuits-st-michel" title="20 Galettes : Traditional Butter Biscuits - St Michel - 130┬ág (20┬áx&nbsp;6.5┬ág)">
          
            <div><img src="https://images.openfoodfacts.org/images/products/302/347/000/1015/front.18.100.jpg" srcset="https://images.openfoodfacts.org/images/products/302/347/000/1015/front.18.200.jpg 2x" alt="20 Galettes : Traditional Butter Biscuits - Product" loading="lazy" width="100" height="26">
</div>
            <span>20 Galettes : Traditional Butter Biscuits - St Michel - 130┬ág (20┬áx&nbsp;6.5┬ág)</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3229820782560/muesli-superfruits-bjorg" title="Muesli Superfruits - Bjorg -&nbsp;375┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/982/078/2560/front_fr.131.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/982/078/2560/front_fr.131.200.jpg 2x" alt="Muesli Superfruits - Product" loading="lazy" width="65" height="100">
</div>
            <span>Muesli Superfruits - Bjorg -&nbsp;375┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/8000500329474/biscuits-kinder-cereale-chocolat-noir-2x6-204g" title="Biscuits Kinder CereAl├® chocolat noir 2x6 - 204g -&nbsp;204┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/800/050/032/9474/front_en.81.100.jpg" srcset="https://images.openfoodfacts.org/images/products/800/050/032/9474/front_en.81.200.jpg 2x" alt="Biscuits Kinder CereAl├® chocolat noir 2x6 - 204g - Product" loading="lazy" width="60" height="100">
</div>
            <span>Biscuits Kinder CereAl├® chocolat noir 2x6 - 204g -&nbsp;204┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7613035833272/perrier" title="Perrier -&nbsp;1┬ál">
          
            <div><img src="https://images.openfoodfacts.org/images/products/761/303/583/3272/front_en.149.100.jpg" srcset="https://images.openfoodfacts.org/images/products/761/303/583/3272/front_en.149.200.jpg 2x" alt="Perrier - Product" loading="lazy" width="28" height="100">
</div>
            <span>Perrier -&nbsp;1┬ál</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5050083516313/cereales-extra-kellogg-s-pepites-chocolat-au-lait" title="C├®r├®ales Extra Kellogg's P├®pites Chocolat au lait -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/505/008/351/6313/front_fr.111.100.jpg" srcset="https://images.openfoodfacts.org/images/products/505/008/351/6313/front_fr.111.200.jpg 2x" alt="C├®r├®ales Extra Kellogg's P├®pites Chocolat au lait - Product" loading="lazy" width="68" height="100">
</div>
            <span>C├®r├®ales Extra Kellogg's P├®pites Chocolat au lait -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3017620429484/nutella-ferrero" title="Nutella - Ferrero -&nbsp;825┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/301/762/042/9484/front_en.292.100.jpg" srcset="https://images.openfoodfacts.org/images/products/301/762/042/9484/front_en.292.200.jpg 2x" alt="Nutella - Product" loading="lazy" width="63" height="100">
</div>
            <span>Nutella - Ferrero -&nbsp;825┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3664346312936/pate-a-tartiner-poulain" title="P├óte ├á tartiner - Poulain -&nbsp;400┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/366/434/631/2936/front_fr.38.100.jpg" srcset="https://images.openfoodfacts.org/images/products/366/434/631/2936/front_fr.38.200.jpg 2x" alt="P├óte ├á tartiner - Product" loading="lazy" width="95" height="100">
</div>
            <span>P├óte ├á tartiner - Poulain -&nbsp;400┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/4006985902304/l-original-cacao-en-poudre-non-sucre-van-houten" title="L'Original - Cacao en poudre non sucr├® - Van houten -&nbsp;250┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/400/698/590/2304/front_fr.149.100.jpg" srcset="https://images.openfoodfacts.org/images/products/400/698/590/2304/front_fr.149.200.jpg 2x" alt="L'Original - Cacao en poudre non sucr├® - Product" loading="lazy" width="77" height="100">
</div>
            <span>L'Original - Cacao en poudre non sucr├® - Van houten -&nbsp;250┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3088543506255/sirop-d-agave-350g-sunny-via" title="SIROP D'AGAVE 350g - Sunny Via -&nbsp;350┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/308/854/350/6255/front_en.230.100.jpg" srcset="https://images.openfoodfacts.org/images/products/308/854/350/6255/front_en.230.200.jpg 2x" alt="Sirop d'agave - Product" loading="lazy" width="50" height="100">
</div>
            <span>SIROP D'AGAVE 350g - Sunny Via -&nbsp;350┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3155251205296/tartine-doux-primevere" title="Tartine Doux - Primev├¿re -&nbsp;250┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/315/525/120/5296/front_en.149.100.jpg" srcset="https://images.openfoodfacts.org/images/products/315/525/120/5296/front_en.149.200.jpg 2x" alt="Tartine Doux - Product" loading="lazy" width="100" height="55">
</div>
            <span>Tartine Doux - Primev├¿re -&nbsp;250┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/59032823/nutella" title="Nutella -&nbsp;630┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/59032823/front_en.171.100.jpg" srcset="https://images.openfoodfacts.org/images/products/59032823/front_en.171.200.jpg 2x" alt="Nutella - Product" loading="lazy" width="63" height="100">
</div>
            <span>Nutella -&nbsp;630┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/80177173/nutella-ferrero" title="Nutella - Ferrero -&nbsp;350┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/80177173/front_en.149.100.jpg" srcset="https://images.openfoodfacts.org/images/products/80177173/front_en.149.200.jpg 2x" alt="Nutella - Product" loading="lazy" width="81" height="100">
</div>
            <span>Nutella - Ferrero -&nbsp;350┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7622210713889/belvita-petit-dejeuner-miel%F0%9F%90%9D%F0%9F%8D%AF-et-pepites-de-chocolat%F0%9F%8D%AB-lu" title="Belvita Petit-D├®jeuner miel­ƒÉØ­ƒì» et p├®pites de chocolat­ƒì½ - LU -&nbsp;435┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/762/221/071/3889/front_fr.136.100.jpg" srcset="https://images.openfoodfacts.org/images/products/762/221/071/3889/front_fr.136.200.jpg 2x" alt="Belvita Petit-D├®jeuner miel­ƒÉØ­ƒì» et p├®pites de chocolat­ƒì½ - Product" loading="lazy" width="62" height="100">
</div>
            <span>Belvita Petit-D├®jeuner miel­ƒÉØ­ƒì» et p├®pites de chocolat­ƒì½ - LU -&nbsp;435┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3068320123264/la-salvetat" title="La salvetat -&nbsp;1,15┬áL">
          
            <div><img src="https://images.openfoodfacts.org/images/products/306/832/012/3264/front_fr.81.100.jpg" srcset="https://images.openfoodfacts.org/images/products/306/832/012/3264/front_fr.81.200.jpg 2x" alt="La salvetat - Product" loading="lazy" width="36" height="100">
</div>
            <span>La salvetat -&nbsp;1,15┬áL</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3229820769165/muesli-avoine-chocolat-bio-bjorg" title="Muesli avoine chocolat bio - Bjorg -&nbsp;375┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/982/076/9165/front_en.148.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/982/076/9165/front_en.148.200.jpg 2x" alt="Muesli avoine chocolat bio - Product" loading="lazy" width="65" height="100">
</div>
            <span>Muesli avoine chocolat bio - Bjorg -&nbsp;375┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5010029220773/weetabix" title="Weetabix -&nbsp;645g">
          
            <div><img src="https://images.openfoodfacts.org/images/products/501/002/922/0773/front_en.128.100.jpg" srcset="https://images.openfoodfacts.org/images/products/501/002/922/0773/front_en.128.200.jpg 2x" alt="Weetabix - Product" loading="lazy" width="94" height="100">
</div>
            <span>Weetabix -&nbsp;645g</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7613036249928/vittel-eau-minerale-naturelle-1-5l" title="VITTEL eau min├®rale naturelle 1,5L -&nbsp;1500┬áml">
          
            <div><img src="https://images.openfoodfacts.org/images/products/761/303/624/9928/front_fr.280.100.jpg" srcset="https://images.openfoodfacts.org/images/products/761/303/624/9928/front_fr.280.200.jpg 2x" alt="VITTEL eau min├®rale naturelle 1,5L - Product" loading="lazy" width="28" height="100">
</div>
            <span>VITTEL eau min├®rale naturelle 1,5L -&nbsp;1500┬áml</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3033710084913/arome-maggi-nestle" title="Arome MAGGI - Nestl├® -&nbsp;200ml">
          
            <div><img src="https://images.openfoodfacts.org/images/products/303/371/008/4913/front_en.106.100.jpg" srcset="https://images.openfoodfacts.org/images/products/303/371/008/4913/front_en.106.200.jpg 2x" alt="Arome MAGGI - Product" loading="lazy" width="35" height="100">
</div>
            <span>Arome MAGGI - Nestl├® -&nbsp;200ml</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/4056489007180/pain-de-mie-special-sandwich-complet-maitre-jean-pierre" title="Pain de Mie Sp├®cial Sandwich Complet - Ma├«tre Jean Pierre -&nbsp;750┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/405/648/900/7180/front_en.115.100.jpg" srcset="https://images.openfoodfacts.org/images/products/405/648/900/7180/front_en.115.200.jpg 2x" alt="Pain de Mie Sp├®cial Sandwich Complet - Product" loading="lazy" width="75" height="100">
</div>
            <span>Pain de Mie Sp├®cial Sandwich Complet - Ma├«tre Jean Pierre -&nbsp;750┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3159470005071/cereales-extra-pepites-chocolat-noisettes-kellogg-s" title="C├®r├®ales Extra P├®pites Chocolat Noisettes - Kellogg's -&nbsp;500┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/315/947/000/5071/front_fr.145.100.jpg" srcset="https://images.openfoodfacts.org/images/products/315/947/000/5071/front_fr.145.200.jpg 2x" alt="C├®r├®ales Extra P├®pites Chocolat Noisettes - Product" loading="lazy" width="64" height="100">
</div>
            <span>C├®r├®ales Extra P├®pites Chocolat Noisettes - Kellogg's -&nbsp;500┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3041090063206/cracotte-cereales-completes-lu" title="Cracotte C├®r├®ales Compl├¿tes - lu -&nbsp;250">
          
            <div><img src="https://images.openfoodfacts.org/images/products/304/109/006/3206/front_fr.132.100.jpg" srcset="https://images.openfoodfacts.org/images/products/304/109/006/3206/front_fr.132.200.jpg 2x" alt="Cracotte C├®r├®ales Compl├¿tes - Product" loading="lazy" width="100" height="66">
</div>
            <span>Cracotte C├®r├®ales Compl├¿tes - lu -&nbsp;250</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3068320120256/natuurlijk-mineraalwater-evian" title="Natuurlijk Mineraalwater - Evian -&nbsp;1.5┬áL">
          
            <div><img src="https://images.openfoodfacts.org/images/products/306/832/012/0256/front_en.61.100.jpg" srcset="https://images.openfoodfacts.org/images/products/306/832/012/0256/front_en.61.200.jpg 2x" alt="Natuurlijk Mineraalwater - Product" loading="lazy" width="32" height="100">
</div>
            <span>Natuurlijk Mineraalwater - Evian -&nbsp;1.5┬áL</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3017620421006/nutella-ferrero" title="Nutella - Ferrero -&nbsp;750┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/301/762/042/1006/front_en.250.100.jpg" srcset="https://images.openfoodfacts.org/images/products/301/762/042/1006/front_en.250.200.jpg 2x" alt="Nutella - Product" loading="lazy" width="63" height="100">
</div>
            <span>Nutella - Ferrero -&nbsp;750┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/5411188112709/almond-no-sugars-alpro" title="Almond no sugars - Alpro -&nbsp;1l">
          
            <div><img src="https://images.openfoodfacts.org/images/products/541/118/811/2709/front_en.269.100.jpg" srcset="https://images.openfoodfacts.org/images/products/541/118/811/2709/front_en.269.200.jpg 2x" alt="Mandeldrink - Product" loading="lazy" width="38" height="100">
</div>
            <span>Almond no sugars - Alpro -&nbsp;1l</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3228886048436/ice-tea-saveur-peche-lipton" title="Ice Tea Saveur Peche - Lipton -&nbsp;1500┬áml">
          
            <div><img src="https://images.openfoodfacts.org/images/products/322/888/604/8436/front_en.219.100.jpg" srcset="https://images.openfoodfacts.org/images/products/322/888/604/8436/front_en.219.200.jpg 2x" alt="Ice Tea Saveur Peche - Product" loading="lazy" width="28" height="100">
</div>
            <span>Ice Tea Saveur Peche - Lipton -&nbsp;1500┬áml</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/7622210476296/the-biscuits-lu-the" title="Th├® - Biscuits - Lu  th├® - 350┬ág&nbsp;Ôä«">
          
            <div><img src="https://images.openfoodfacts.org/images/products/762/221/047/6296/front_fr.63.100.jpg" srcset="https://images.openfoodfacts.org/images/products/762/221/047/6296/front_fr.63.200.jpg 2x" alt="Th├® - Biscuits - Product" loading="lazy" width="100" height="49">
</div>
            <span>Th├® - Biscuits - Lu  th├® - 350┬ág&nbsp;Ôä«</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3251490307002/gouter-pepites-de-chocolat-gerble" title="Go├╗ter p├®pites de chocolat - Gerbl├® -&nbsp;250┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/325/149/030/7002/front_fr.55.100.jpg" srcset="https://images.openfoodfacts.org/images/products/325/149/030/7002/front_fr.55.200.jpg 2x" alt="Go├╗ter p├®pites de chocolat - Product" loading="lazy" width="100" height="51">
</div>
            <span>Go├╗ter p├®pites de chocolat - Gerbl├® -&nbsp;250┬ág</span>
          </a>
        </li>
        
      
      
        <li>
        
          <a href="/product/3284230011884/8-pains-au-lait-la-boulangere-bio" title="8 Pains au lait - La Boulang├¿re Bio -&nbsp;280┬ág">
          
            <div><img src="https://images.openfoodfacts.org/images/products/328/423/001/1884/front_fr.109.100.jpg" srcset="https://images.openfoodfacts.org/images/products/328/423/001/1884/front_fr.109.200.jpg 2x" alt="8 Pains au lait - Product" loading="lazy" width="51" height="100">
</div>
            <span>8 Pains au lait - La Boulang├¿re Bio -&nbsp;280┬ág</span>
          </a>
        </li>
        
      
      
		</ul>
  </div>
        """
    let singleProductStr = """
        <section class="row" id="product">
        <div class="large-12 column">
            
            <div class="card" style="border-top:none">
                <div id="prodBanner" style="display:none"></div>
                <div class="card-section">
                    
                        <div class="row">
                            <div class="medium-4 small-12 columns">
                                <!-- start templates/web/pages/product/product_page.tt.html -->

<div id="image_box_front" class="image_box">

<figure itemprop="image" itemscope="" itemtype="https://schema.org/ImageObject" style="margin-bottom:0">
   
    <a data-reveal-id="drop_front">
        <img style="border-radius:10px;margin-bottom:0.5rem;" id="og_image" class="product_image" src="https://images.openfoodfacts.org/images/products/322/888/604/8436/front_en.219.400.jpg" alt="Ice Tea Saveur Peche - Product" itemprop="thumbnail" loading="lazy" width="113" height="400">
    </a>

    <meta itemprop="imgid" content="front">
    
    <figcaption>
        <a href="/cgi/product_image.pl?code=3228886048436&amp;id=front_en" title="Photo detail and attribution information">
            <!--?xml version="1.0" encoding="UTF-8" standalone="no"?--><svg xmlns:dc="http://purl.org/dc/elements/1.1/" xmlns:cc="http://creativecommons.org/ns#" xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" xmlns:svg="http://www.w3.org/2000/svg" xmlns="http://www.w3.org/2000/svg" xmlns:sodipodi="http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd" xmlns:inkscape="http://www.inkscape.org/namespaces/inkscape" viewBox="0 0 24 24" version="1.1" id="svg6" sodipodi:docname="material-cc-icon.svg" inkscape:version="0.92.3 (2405546, 2018-03-11)" class="icon" aria-hidden="true" focusable="false"><metadata id="metadata12"><rdf:rdf><cc:work rdf:about=""><dc:format>image/svg+xml</dc:format><dc:type rdf:resource="http://purl.org/dc/dcmitype/StillImage"></dc:type><dc:title></dc:title></cc:work></rdf:rdf></metadata><defs id="defs10"></defs><sodipodi:namedview pagecolor="#ffffff" bordercolor="#666666" borderopacity="1" objecttolerance="10" gridtolerance="10" guidetolerance="10" inkscape:pageopacity="0" inkscape:pageshadow="2" inkscape:window-width="1920" inkscape:window-height="1017" id="namedview8" showgrid="true" inkscape:zoom="27.812867" inkscape:cx="9.3958632" inkscape:cy="15.517418" inkscape:window-x="-8" inkscape:window-y="-8" inkscape:window-maximized="1" inkscape:current-layer="svg6"><inkscape:grid type="xygrid" id="grid822"></inkscape:grid></sodipodi:namedview><path fill="none" d="M0 0h24v24H0V0zm0 0h24v24H0V0z" id="path2"></path><path d="M 12 2 C 6.48 2 2 6.48 2 12 C 2 17.52 6.48 22 12 22 C 17.52 22 22 17.52 22 12 C 22 6.48 17.52 2 12 2 z M 12 4 C 16.42 4 20 7.58 20 12 C 20 16.42 16.42 20 12 20 C 7.58 20 4 16.42 4 12 C 4 7.58 7.58 4 12 4 z " id="path826"></path><path inkscape:connector-curvature="0" d="m 11.796655,10.128816 -1.509128,0.784662 C 10.126301,10.578702 9.9288153,10.343551 9.6943676,10.20943 9.4595671,10.07566 9.2416645,10.008424 9.0403064,10.008424 c -1.005381,0 -1.5087753,0.663565 -1.5087753,1.9914 0,0.60337 0.1274331,1.085643 0.3819463,1.447875 0.2548654,0.362233 0.6304753,0.543525 1.126829,0.543525 0.6572295,0 1.1197886,-0.322102 1.3883826,-0.965601 l 1.38768,0.704048 C 11.521372,14.279884 11.112321,14.71217 10.589212,15.027232 10.066808,15.342645 9.4898419,15.5 8.859366,15.5 7.8536329,15.5 7.0418658,15.191979 6.4251197,14.574528 5.8083736,13.957782 5.5,13.099547 5.5,12.000177 5.5,10.927206 5.8118935,10.076012 6.4353281,9.4455372 7.0587628,8.815414 7.8465931,8.5000007 8.7991702,8.5000007 10.194241,8.4992963 11.192934,9.0424697 11.796655,10.128816 Z" id="path826-9" style="stroke-width:0.35202414"></path><path inkscape:connector-curvature="0" d="m 18.276237,10.128816 -1.488709,0.784662 c -0.160875,-0.334776 -0.359065,-0.569927 -0.593512,-0.704048 -0.235153,-0.13377 -0.460096,-0.201006 -0.673774,-0.201006 -1.005734,0 -1.509128,0.663565 -1.509128,1.9914 0,0.60337 0.127785,1.085643 0.382298,1.447875 0.254514,0.362233 0.629771,0.543525 1.12683,0.543525 0.656524,0 1.119436,-0.322102 1.387326,-0.965601 l 1.408096,0.704048 c -0.30802,0.550213 -0.724113,0.982499 -1.246517,1.297561 C 16.54604,15.342645 15.976113,15.5 15.359366,15.5 14.339904,15.5 13.525673,15.191979 12.915967,14.574528 12.304853,13.957782 12,13.099547 12,12.000177 c 0,-1.072971 0.311541,-1.924165 0.93568,-2.5546398 0.623082,-0.6301232 1.410913,-0.9455365 2.363138,-0.9455365 1.394719,-7.044e-4 2.387779,0.5424689 2.977419,1.6288153 z" id="path4" style="stroke-width:0.35202414"></path></svg>
        </a>
    </figcaption>
</figure>

<a data-reveal-id="drop_front" style="border-radius:10px;border-width:0;">
    <button class="button small round white-button"><span class="material-icons material-symbols-button">zoom_in</span> <span>Zoom</span></button>
</a>

<div id="drop_front" class="reveal-modal" data-reveal="" aria-labelledby="modalTitle_front" aria-hidden="true" role="dialog" about="">
    <h2 id="modalTitle_front"></h2>
    <img src="https://images.openfoodfacts.org/images/products/322/888/604/8436/front_en.219.full.jpg" alt="Ice Tea Saveur Peche - Product" itemprop="contentUrl" loading="lazy">
    <a class="close-reveal-modal" aria-label="Close" href="#">├ù</a>
    <meta itemprop="representativeOfPage" content="false">
    <meta itemprop="license" content="https://creativecommons.org/licenses/by-sa/3.0/">
    <meta itemprop="caption" content="Ice Tea Saveur Peche - Product">
</div>

</div>
  
<!-- end templates/web/pages/product/product_page.tt.html -->

                            </div>
                            <div class="medium-8 small-12 columns">
                       


                    <h2 class="title-1" property="food:name" itemprop="name">Ice Tea Saveur Peche - Lipton - 1500┬áml</h2>
                    
            <!-- Obsolete product -->
            

            <!-- GS1-Prefixes for restricted circulation numbers within a company - warn for possible conflicts -->
            

            
                <div data-alert="" class="alert-box info" id="warning_not_complete" style="display: block;">
                    This product page is not complete. You can help to complete it by editing it and adding more data from the photos we have, or by taking more photos using the app for <a href="https://android.openfoodfacts.org">Android</a> or <a href="https://ios.openfoodfacts.org">iPhone/iPad</a>. Thank you!
                    <a href="#" class="close">×</a>
                </div>
            

            <!-- owner -->
            
                <p>
                    Some of the data for this product has been provided directly by the manufacturer <a href="/editor/org-pepsico-france">PEPSICO FRANCE</a>.
                    
                    
                </p>
                                
                    
                    <!-- Display UPC code if the EAN starts with 0 -->
                        
                            <p id="barcode_paragraph">
                                Barcode:  <span id="barcode" property="food:code" itemprop="gtin13" style="speak-as:digits;">3228886048436</span> (EAN / EAN-13)
                            </p>
                            <div property="gr:hasEAN_UCC-13" content="3228886048436" datatype="xsd:string"></div>
                        
                        
                        <!-- start templates/web/common/includes/display_field.tt.html -->

<p id="field_quantity">
    <span class="field">Quantity: </span>
    <span class="field_value" id="field_quantity_value">1500 ml</span>
</p>

<!-- end templates/web/common/includes/display_field.tt.html -->
<!-- start templates/web/common/includes/display_field.tt.html -->

<p id="field_packaging">
    <span class="field">Packaging: </span>
    <span class="field_value" id="field_packaging_value"><a href="/packaging/plastic" class="tag well_known">Plastic</a>, <a href="/packaging/pet-polyethylene-terephthalate" class="tag well_known">PET - Polyethylene terephthalate</a>, <a href="/packaging/bottle" class="tag well_known">Bottle</a>, <a href="/packaging/pet-bottle" class="tag user_defined">Pet-bottle</a>, <a href="/packaging/pp-lid" class="tag user_defined">Pp-lid</a>, <a href="/packaging/fr:bouchon-en-plastique" class="tag user_defined" lang="fr">fr:Bouchon en plastique</a>, <a href="/packaging/fr:bouteille-en-plastique" class="tag user_defined" lang="fr">fr:Bouteille en plastique</a>, <a href="/packaging/fr:bouteille-plastique-recycle" class="tag user_defined" lang="fr">fr:Bouteille plastique recycl├®</a></span>
</p>

<!-- end templates/web/common/includes/display_field.tt.html -->
<!-- start templates/web/common/includes/display_field.tt.html -->

<p id="field_brands">
    <span class="field">Brands: </span>
    <span class="field_value" id="field_brands_value"><a itemprop="brand" href="/brand/lipton">Lipton</a></span>
</p>

<!-- end templates/web/common/includes/display_field.tt.html -->
<!-- start templates/web/common/includes/display_field.tt.html -->

<p id="field_categories">
    <span class="field">Categories: </span>
    <span class="field_value" id="field_categories_value"><a href="/category/plant-based-foods-and-beverages" class="tag well_known">Plant-based foods and beverages</a>, <a href="/category/beverages" class="tag well_known">Beverages</a>, <a href="/category/plant-based-beverages" class="tag well_known">Plant-based beverages</a>, <a href="/category/artificially-sweetened-beverages" class="tag well_known">Artificially sweetened beverages</a>, <a href="/category/tea-based-beverages" class="tag well_known">Tea-based beverages</a>, <a href="/category/iced-teas" class="tag well_known">Iced teas</a>, <a href="/category/peach-flavored-iced-teas" class="tag well_known">Peach flavored iced teas</a>, <a href="/category/sweetened-beverages" class="tag well_known">Sweetened beverages</a></span>
</p>

<!-- end templates/web/common/includes/display_field.tt.html -->
<!-- start templates/web/common/includes/display_field.tt.html -->

<p id="field_labels">
    <span class="field">Labels, certifications, awards: </span>
    <span class="field_value" id="field_labels_value"><a href="/label/green-dot" class="tag well_known">Green Dot</a>, <a href="/label/rainforest-alliance" class="tag well_known">Rainforest Alliance</a>, <a href="/label/fr:triman" class="tag user_defined" lang="fr">fr:Triman</a>, <a href="/label/fr:emballage-plastique-100-recycle" class="tag user_defined" lang="fr">fr:Emballage-plastique-100-recycle</a>, <a href="/label/fr:the-noir-rainforest-alliance-100-verifie" class="tag user_defined" lang="fr">fr:Th├® noir Rainforest Alliance 100┬á% v├®rifi├®</a><br><img src="/images/lang/en/labels/green-dot.90x90.svg" style="display:inline" width="90" height="90">
<img src="/images/lang/en/labels/rainforest-alliance.90x90.svg" style="display:inline" width="90" height="90">
<img src="/images/lang/en/labels/triman.90x90.svg" style="display:inline" width="90" height="90">
</span>
</p>

<!-- end templates/web/common/includes/display_field.tt.html -->
<!-- start templates/web/common/includes/display_field.tt.html -->

<p id="field_manufacturing_places">
    <span class="field">Manufacturing or processing places: </span>
    <span class="field_value" id="field_manufacturing_places_value"><a href="/manufacturing-place/france">France</a></span>
</p>

<!-- end templates/web/common/includes/display_field.tt.html -->
<!-- start templates/web/common/includes/display_field.tt.html -->

<p id="field_stores">
    <span class="field">Stores: </span>
    <span class="field_value" id="field_stores_value"><a href="/store/magasins-u">Magasins U</a>, <a href="/store/intermarche">Intermarch├®</a>, <a href="/store/auchan">Auchan</a>, <a href="/store/carrefour-fr">carrefour.fr</a></span>
</p>

<!-- end templates/web/common/includes/display_field.tt.html -->
<!-- start templates/web/common/includes/display_field.tt.html -->

<p id="field_countries">
    <span class="field">Countries where sold: </span>
    <span class="field_value" id="field_countries_value"><a href="/country/france" class="tag well_known">France</a></span>
</p>

<!-- end templates/web/common/includes/display_field.tt.html -->


                    
                            </div>
                        </div>
                       

                    </div>
                </div>
            </div>
        </section>
    """
    let nutellaDescriptionPage = """
            <section class="row" id="product">
            <div class="large-12 column">
            
                <div class="card" style="border-top:none">
                    <div id="prodBanner" style="display:none"></div>
                    <div class="card-section">
                    
                            <div class="row">
                                <div class="medium-4 small-12 columns">
                                    <!-- start templates/web/pages/product/product_page.tt.html -->

    <div id="image_box_front" class="image_box">

    <figure itemprop="image" itemscope="" itemtype="https://schema.org/ImageObject" style="margin-bottom:0">
   
        <img style="border-radius:10px;margin-bottom:0.5rem;" id="og_image" class="product_image" src="https://images.openfoodfacts.org/images/products/301/762/042/2003/front_en.430.400.jpg" alt="Nutella - Product" itemprop="thumbnail" loading="lazy" width="400" height="274">

        <meta itemprop="imgid" content="front">
    
        <figcaption>
            <a href="/cgi/product_image.pl?code=3017620422003&amp;id=front_en" title="Photo detail and attribution information">
                <!--?xml version="1.0" encoding="UTF-8" standalone="no"?--><svg xmlns:dc="http://purl.org/dc/elements/1.1/" xmlns:cc="http://creativecommons.org/ns#" xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" xmlns:svg="http://www.w3.org/2000/svg" xmlns="http://www.w3.org/2000/svg" xmlns:sodipodi="http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd" xmlns:inkscape="http://www.inkscape.org/namespaces/inkscape" viewBox="0 0 24 24" version="1.1" id="svg6" sodipodi:docname="material-cc-icon.svg" inkscape:version="0.92.3 (2405546, 2018-03-11)" class="icon" aria-hidden="true" focusable="false"><metadata id="metadata12"><rdf:rdf><cc:work rdf:about=""><dc:format>image/svg+xml</dc:format><dc:type rdf:resource="http://purl.org/dc/dcmitype/StillImage"></dc:type><dc:title></dc:title></cc:work></rdf:rdf></metadata><defs id="defs10"></defs><sodipodi:namedview pagecolor="#ffffff" bordercolor="#666666" borderopacity="1" objecttolerance="10" gridtolerance="10" guidetolerance="10" inkscape:pageopacity="0" inkscape:pageshadow="2" inkscape:window-width="1920" inkscape:window-height="1017" id="namedview8" showgrid="true" inkscape:zoom="27.812867" inkscape:cx="9.3958632" inkscape:cy="15.517418" inkscape:window-x="-8" inkscape:window-y="-8" inkscape:window-maximized="1" inkscape:current-layer="svg6"><inkscape:grid type="xygrid" id="grid822"></inkscape:grid></sodipodi:namedview><path fill="none" d="M0 0h24v24H0V0zm0 0h24v24H0V0z" id="path2"></path><path d="M 12 2 C 6.48 2 2 6.48 2 12 C 2 17.52 6.48 22 12 22 C 17.52 22 22 17.52 22 12 C 22 6.48 17.52 2 12 2 z M 12 4 C 16.42 4 20 7.58 20 12 C 20 16.42 16.42 20 12 20 C 7.58 20 4 16.42 4 12 C 4 7.58 7.58 4 12 4 z " id="path826"></path><path inkscape:connector-curvature="0" d="m 11.796655,10.128816 -1.509128,0.784662 C 10.126301,10.578702 9.9288153,10.343551 9.6943676,10.20943 9.4595671,10.07566 9.2416645,10.008424 9.0403064,10.008424 c -1.005381,0 -1.5087753,0.663565 -1.5087753,1.9914 0,0.60337 0.1274331,1.085643 0.3819463,1.447875 0.2548654,0.362233 0.6304753,0.543525 1.126829,0.543525 0.6572295,0 1.1197886,-0.322102 1.3883826,-0.965601 l 1.38768,0.704048 C 11.521372,14.279884 11.112321,14.71217 10.589212,15.027232 10.066808,15.342645 9.4898419,15.5 8.859366,15.5 7.8536329,15.5 7.0418658,15.191979 6.4251197,14.574528 5.8083736,13.957782 5.5,13.099547 5.5,12.000177 5.5,10.927206 5.8118935,10.076012 6.4353281,9.4455372 7.0587628,8.815414 7.8465931,8.5000007 8.7991702,8.5000007 10.194241,8.4992963 11.192934,9.0424697 11.796655,10.128816 Z" id="path826-9" style="stroke-width:0.35202414"></path><path inkscape:connector-curvature="0" d="m 18.276237,10.128816 -1.488709,0.784662 c -0.160875,-0.334776 -0.359065,-0.569927 -0.593512,-0.704048 -0.235153,-0.13377 -0.460096,-0.201006 -0.673774,-0.201006 -1.005734,0 -1.509128,0.663565 -1.509128,1.9914 0,0.60337 0.127785,1.085643 0.382298,1.447875 0.254514,0.362233 0.629771,0.543525 1.12683,0.543525 0.656524,0 1.119436,-0.322102 1.387326,-0.965601 l 1.408096,0.704048 c -0.30802,0.550213 -0.724113,0.982499 -1.246517,1.297561 C 16.54604,15.342645 15.976113,15.5 15.359366,15.5 14.339904,15.5 13.525673,15.191979 12.915967,14.574528 12.304853,13.957782 12,13.099547 12,12.000177 c 0,-1.072971 0.311541,-1.924165 0.93568,-2.5546398 0.623082,-0.6301232 1.410913,-0.9455365 2.363138,-0.9455365 1.394719,-7.044e-4 2.387779,0.5424689 2.977419,1.6288153 z" id="path4" style="stroke-width:0.35202414"></path></svg>
            </a>
        </figcaption>
    </figure>

    <a data-reveal-id="drop_front" style="border-radius:10px;border-width:0;">
        <button class="button small round white-button"><span class="material-icons material-symbols-button">zoom_in</span> <span>Zoom</span></button>
    </a>

    <div id="drop_front" class="reveal-modal" data-reveal="" aria-labelledby="modalTitle_front" aria-hidden="true" role="dialog" about="">
        <h2 id="modalTitle_front"></h2>
        <img src="https://images.openfoodfacts.org/images/products/301/762/042/2003/front_en.430.full.jpg" alt="Nutella - Product" itemprop="contentUrl" loading="lazy">
        <a class="close-reveal-modal" aria-label="Close" href="#">×</a>
        <meta itemprop="representativeOfPage" content="false">
        <meta itemprop="license" content="https://creativecommons.org/licenses/by-sa/3.0/">
        <meta itemprop="caption" content="Nutella - Product">
    </div>

    </div>
  
    <!-- end templates/web/pages/product/product_page.tt.html -->

                                </div>
                                <div class="medium-8 small-12 columns">
                       


                        <h2 class="title-1" property="food:name" itemprop="name">Nutella - Ferrero - 400&nbsp;g</h2>
                    
                <!-- Obsolete product -->
            

                <!-- GS1-Prefixes for restricted circulation numbers within a company - warn for possible conflicts -->
            

            
                    <div data-alert="" class="alert-box info" id="warning_not_complete" style="display: block;">
                        This product page is not complete. You can help to complete it by editing it and adding more data from the photos we have, or by taking more photos using the app for <a href="https://android.openfoodfacts.org">Android</a> or <a href="https://ios.openfoodfacts.org">iPhone/iPad</a>. Thank you!
                        <a href="#" class="close">×</a>
                    </div>
            

                <!-- owner -->
            
                    <p>
                        Some of the data for this product has been provided directly by the manufacturer <a href="/editor/org-ferrero-france-commerciale">FERRERO FRANCE COMMERCIALE</a>.
                    
                    
                    </p>
                                
                    
                        <!-- Display UPC code if the EAN starts with 0 -->
                        
                                <p id="barcode_paragraph">
                                    Barcode:  <span id="barcode" property="food:code" itemprop="gtin13" style="speak-as:digits;">3017620422003</span> (EAN / EAN-13)
                                </p>
                                <div property="gr:hasEAN_UCC-13" content="3017620422003" datatype="xsd:string"></div>
                        
                        
                            <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_generic_name">
        <span class="field">Common name: </span>
        <span class="field_value" id="field_generic_name_value"><span itemprop="description">Nutella</span></span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_quantity">
        <span class="field">Quantity: </span>
        <span class="field_value" id="field_quantity_value">400 g</span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_packaging">
        <span class="field">Packaging: </span>
        <span class="field_value" id="field_packaging_value"><a href="/packaging/de:1-deckel-aus-kunststoff" class="tag user_defined" lang="de">de:1 Deckel aus Kunststoff</a>, <a href="/packaging/de:1-deckel-aus-pappe" class="tag user_defined" lang="de">de:1 Deckel aus Pappe</a>, <a href="/packaging/de:1-folie-aus-kunststoff" class="tag user_defined" lang="de">de:1 Folie aus Kunststoff</a>, <a href="/packaging/de:1-jar-aus-klarglas" class="tag user_defined" lang="de">de:1 Jar aus Klarglas</a></span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_brands">
        <span class="field">Brands: </span>
        <span class="field_value" id="field_brands_value"><a itemprop="brand" href="/brand/ferrero">Ferrero</a></span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_categories">
        <span class="field">Categories: </span>
        <span class="field_value" id="field_categories_value"><a href="/category/dairies" class="tag well_known">Dairies</a>, <a href="/category/fermented-foods" class="tag well_known">Fermented foods</a>, <a href="/category/breakfasts" class="tag well_known">Breakfasts</a>, <a href="/category/fermented-milk-products" class="tag well_known">Fermented milk products</a>, <a href="/category/spreads" class="tag well_known">Spreads</a>, <a href="/category/creams" class="tag well_known">Creams</a>, <a href="/category/sweet-spreads" class="tag well_known">Sweet spreads</a>, <a href="/category/fermented-creams" class="tag well_known">Fermented creams</a>, <a href="/category/sour-creams" class="tag well_known">Sour creams</a>, <a href="/category/fr:pates-a-tartiner" class="tag user_defined" lang="fr">fr:Pâtes à tartiner</a>, <a href="/category/hazelnut-spreads" class="tag well_known">Hazelnut spreads</a>, <a href="/category/chocolate-spreads" class="tag well_known">Chocolate spreads</a>, <a href="/category/cocoa-and-hazelnuts-spreads" class="tag well_known">Cocoa and hazelnuts spreads</a></span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_labels">
        <span class="field">Labels, certifications, awards: </span>
        <span class="field_value" id="field_labels_value"><a href="/label/organic" class="tag well_known">Organic</a>, <a href="/label/eu-organic" class="tag well_known">EU Organic</a>, <a href="/label/kosher" class="tag well_known">Kosher</a>, <a href="/label/100-muscle" class="tag well_known">100% muscle</a>, <a href="/label/100-natural" class="tag well_known">100% natural</a>, <a href="/label/contains-gluten" class="tag well_known">Contains gluten</a>, <a href="/label/dk-%C3%B8ko-100" class="tag well_known">DK-ØKO-100</a>, <a href="/label/orthodox-union-kosher" class="tag well_known">Orthodox Union Kosher</a><br><img src="/images/lang/en/labels/eu-organic.135x90.svg" style="display:inline" width="135" height="90">
    <img src="/images/lang/en/labels/orthodox-union-kosher.90x90.svg" style="display:inline" width="90" height="90">
    </span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_origin">
        <span class="field">Origin of the product and/or its ingredients: </span>
        <span class="field_value" id="field_origin_value">CrookLandia</span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_manufacturing_places">
        <span class="field">Manufacturing or processing places: </span>
        <span class="field_value" id="field_manufacturing_places_value"><a href="/manufacturing-place/sboop-dope-trap-house">Sboop Dope Trap House</a></span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_emb_codes">
        <span class="field">EMB code: </span>
        <span class="field_value" id="field_emb_codes_value"><a href="/packager-code/emb-53062">EMB 53062</a> - <a href="/city/chateau-gontier-mayenne-france">Château-Gontier (Mayenne, France)</a></span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_stores">
        <span class="field">Stores: </span>
        <span class="field_value" id="field_stores_value"><a href="/store/hermes">Hermes</a></span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->
    <!-- start templates/web/common/includes/display_field.tt.html -->

    <p id="field_countries">
        <span class="field">Countries where sold: </span>
        <span class="field_value" id="field_countries_value"><a href="/country/it:angolo" class="tag user_defined" lang="it">it:Angolo</a>, <a href="/country/it:chiongio" class="tag user_defined" lang="it">it:Chiongio</a>, <a href="/country/it:crooklandia" class="tag user_defined" lang="it">it:CrookLandia</a>, <a href="/country/it:kolkata" class="tag user_defined" lang="it">it:Kolkata</a>, <a href="/country/it:lagos" class="tag user_defined" lang="it">it:Lagos</a>, <a href="/country/it:segagal" class="tag user_defined" lang="it">it:Segagal</a>, <a href="/country/it:vena-media" class="tag user_defined" lang="it">it:Vena Media</a></span>
    </p>

    <!-- end templates/web/common/includes/display_field.tt.html -->


                    
                                </div>
                            </div>
                       

                        </div>
                    </div>
                </div>
            </section>
        """
